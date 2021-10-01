using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LAB_2
{
    public partial class Task3 : Form
    {
        public Task3()
        {
            InitializeComponent();
            StringField.Text = Properties.Settings.Default.expression.ToString();
        }

        public void Task3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form mainForm = Application.OpenForms[0];
            mainForm.Show();
        }

        private void CalculationButton_Click(object sender, EventArgs e)
        {
            //Запрос на ввод строки
            string expression = StringField.Text;

            //Логика
            ProgrammeResult inputCheckResult = Logic.InputCheckTask3(expression);
            ProgrammeResult programmeResult;
            if (inputCheckResult.GetSuccessStatus())
                programmeResult = Logic.CalculateSum(expression);
            else
                programmeResult = new ProgrammeResult();

            //Вывод результата
            MessageBox.Show(inputCheckResult.GetMessage() + '\n' + programmeResult.GetMessage());
        }

        //Очистка ввода
        private void ClearButton_Click(object sender, EventArgs e)
        {
            StringField.Text = Properties.Settings.Default.expression.ToString();
            MessageBox.Show("Введенные данные очищены!");
        }
    }
}
