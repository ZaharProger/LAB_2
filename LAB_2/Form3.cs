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
            ArrivalHoursField.Text = Properties.Settings.Default.arrivalHours.ToString();
            ArrivalMinutesField.Text = Properties.Settings.Default.arrivalMinutes.ToString();
            DepartureHoursField.Text = Properties.Settings.Default.departureHours.ToString();
            DepartureMinutesField.Text = Properties.Settings.Default.departureMinutes.ToString();
            PassengerHoursField.Text = Properties.Settings.Default.passengerHours.ToString();
            PassengerMinutesField.Text = Properties.Settings.Default.passengerMinutes.ToString();
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

        //Очистка ввода
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ArrivalHoursField.Text = Properties.Settings.Default.arrivalHours.ToString();
            ArrivalMinutesField.Text = Properties.Settings.Default.arrivalMinutes.ToString();
            DepartureHoursField.Text = Properties.Settings.Default.departureHours.ToString();
            DepartureMinutesField.Text = Properties.Settings.Default.departureMinutes.ToString();
            PassengerHoursField.Text = Properties.Settings.Default.passengerHours.ToString();
            PassengerMinutesField.Text = Properties.Settings.Default.passengerMinutes.ToString();
            MessageBox.Show("Введенные данные очищены!");
        }

        #region[Переход по элементам формы клавишами]
        private void ArrivalHoursField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Right || e.KeyCode == Keys.Left)
                ArrivalMinutesField.Focus();
            else if (e.KeyCode == Keys.Up)
                ClearButton.Focus();
            else if (e.KeyCode == Keys.Down)
                DepartureHoursField.Focus();
        }

        private void ArrivalMinutesField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                DepartureHoursField.Focus();
            else if (e.KeyCode == Keys.Up)
                ClearButton.Focus();
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
                ArrivalHoursField.Focus();
            else if (e.KeyCode == Keys.Down)
                DepartureMinutesField.Focus();
        }

        private void DepartureHoursField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                DepartureMinutesField.Focus();
            else if (e.KeyCode == Keys.Up)
                ArrivalHoursField.Focus();
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
                DepartureMinutesField.Focus();
            else if (e.KeyCode == Keys.Down)
                PassengerHoursField.Focus();
        }

        private void DepartureMinutesField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                PassengerHoursField.Focus();
            else if (e.KeyCode == Keys.Up)
                ArrivalMinutesField.Focus();
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
                DepartureHoursField.Focus();
            else if (e.KeyCode == Keys.Down)
                PassengerMinutesField.Focus();
        }

        private void PassengerHoursField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                PassengerMinutesField.Focus();
            else if (e.KeyCode == Keys.Up)
                DepartureHoursField.Focus();
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
                PassengerMinutesField.Focus();
            else if (e.KeyCode == Keys.Down)
                CalculationButton.Focus();
        }

        private void PassengerMinutesField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                CalculationButton.Focus();
            else if (e.KeyCode == Keys.Up)
                DepartureMinutesField.Focus();
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
                PassengerHoursField.Focus();
            else if (e.KeyCode == Keys.Down)
                CalculationButton.Focus();
        }

        private void CalculationButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                PassengerMinutesField.Focus();
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Down)
                ClearButton.Focus();
        }

        private void ClearButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
                CalculationButton.Focus();
            else if (e.KeyCode == Keys.Down)
                ArrivalHoursField.Focus();

        }
        #endregion[Переход по полям ввода клавишей Enter]

        private void Task1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
