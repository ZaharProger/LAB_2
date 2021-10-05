using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LAB_2
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
            GroupSizeField.Text = Properties.Settings.Default.groupSize.ToString();
            NumsField.Text = Properties.Settings.Default.nums.ToString();
        }

        private void Task2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.groupSize = GroupSizeField.Text;
            Properties.Settings.Default.nums = NumsField.Text;
            Properties.Settings.Default.Save();
        }

        private void Task2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form mainForm = Application.OpenForms[0];
            mainForm.Show();
        }

        private void CalculationButton_Click(object sender, EventArgs e)
        {
            //Получение данных
            string groupSize = GroupSizeField.Text;
            string[] nums = NumsField.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            //Программная логика      
            ProgrammeResult groupSizeCheckResult = Logic.InputCheckTask2(groupSize);
            ProgrammeResult numsCheckResult = new ProgrammeResult("-", true);
            int i = 0;
            while (i < nums.Length && numsCheckResult.GetSuccessStatus())
            {
                numsCheckResult = Logic.InputCheckTask2(nums[i]);
                ++i;
            }
            ProgrammeResult programmeResult;
            if (groupSizeCheckResult.GetSuccessStatus() && numsCheckResult.GetSuccessStatus())
                programmeResult = Logic.FindGroup(groupSize, nums);
            else
                programmeResult = new ProgrammeResult();

            //Вывод результата
            MessageBox.Show(groupSizeCheckResult.GetMessage() + '\n' + numsCheckResult.GetMessage() + '\n' + programmeResult.GetMessage());
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            GroupSizeField.Text = "";
            NumsField.Text = "";
            MessageBox.Show("Введенные данные очищены!");
        }

        #region[Перемещение клавишами по элементам формы]

        private void GroupSizeField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                NumsField.Focus();
            else if (e.KeyCode == Keys.Up)
                ClearButton.Focus();
        }

        private void NumsField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                GroupSizeField.Focus();
            else if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                CalculationButton.Focus();
        }

        private void CalculationButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                NumsField.Focus();
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Down)
                ClearButton.Focus();
        }

        private void ClearButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
                CalculationButton.Focus();
            else if (e.KeyCode == Keys.Down)
                GroupSizeField.Focus();
        }
        #endregion[Перемещение клавишами по элементам формы]

        private void Task2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
