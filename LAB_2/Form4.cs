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

        private void Task2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form mainForm = Application.OpenForms[0];
            mainForm.Show();
        }

        private void CalculationButton_Click(object sender, EventArgs e)
        {
            //Получение данных
            string groupSize = GroupSizeField.Text;
            string[] nums = NumsField.Text.Split();

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
    }
}
