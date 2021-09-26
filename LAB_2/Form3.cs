using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LAB_2
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void Task1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form mainForm = Application.OpenForms[0];
            mainForm.Show();
        }

        private void CalculationButton_Click(object sender, EventArgs e)
        {
            //Получение данных
            string[] hours = new string[] { ArrivalHoursField.Text, DepartureHoursField.Text, PassengerHoursField.Text };
            string[] minutes = new string[] { ArrivalMinutesField.Text, DepartureMinutesField.Text, PassengerMinutesField.Text };

            //Запуск логики программы
            byte i = 0;
            ProgrammeResult inputCheckResult = new ProgrammeResult("-", true);
            while (i < hours.Length && inputCheckResult.GetSuccessStatus())
            {
                inputCheckResult = Logic.InputCheckTask1(ref hours[i], ref minutes[i]);
                ++i;
            }
            ProgrammeResult programmeResult;
            if (inputCheckResult.GetSuccessStatus())
                programmeResult = Logic.GetTrainPosition(hours, minutes);
            else
                programmeResult = new ProgrammeResult();

            //Вывод результата
            MessageBox.Show(inputCheckResult.GetMessage() + '\n' + programmeResult.GetMessage());
        }
    }
}
