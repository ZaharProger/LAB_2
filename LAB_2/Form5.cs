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
        }

        public void Task3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form mainForm = Application.OpenForms[0];
            mainForm.Show();
        }
    }
}
