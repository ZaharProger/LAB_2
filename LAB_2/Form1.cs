using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_2
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        //Вызов информации о программе по нажатию кнопки
        private void InfoButton_Click(object sender, EventArgs e)
        {
            Form programmeInfoForm = new ProgrammeInfo();
            programmeInfoForm.Show();
            Hide();
        }

        //Вызов Задания 1 по нажатию кнопки
        private void Task1Button_Click(object sender, EventArgs e)
        {
            Form task1Form = new Task1();
            task1Form.Show();
            Hide();
        }

        //Вызов Задания 2 по нажатию кнопки 
        private void Task2Button_Click(object sender, EventArgs e)
        {
            Form task2Form = new Task2();
            task2Form.Show();
            Hide();
        }

        //Вызов Задания 3 по нажатию кнопки
        private void Task3Button_Click(object sender, EventArgs e)
        {
            Form task3Form = new Task3();
            task3Form.Show();
            Hide();
        }

        //Закрытие формы клавишей 
        private void MainMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        #region[Переход по элементам формы клавишами]
        private void Task1Button_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                Task2Button.Focus();
            else if (e.KeyCode == Keys.Left)
                Task3Button.Focus();
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                InfoButton.Focus();
        }

        private void Task2Button_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                Task3Button.Focus();
            else if (e.KeyCode == Keys.Left)
                Task1Button.Focus();
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                InfoButton.Focus();
        }

        private void Task3Button_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                Task1Button.Focus();
            else if (e.KeyCode == Keys.Left)
                Task2Button.Focus();
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                InfoButton.Focus();
        }

        private void InfoButton_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                Task1Button.Focus();
        }
        #endregion[Переход по элементам формы клавишами]
    }
}
