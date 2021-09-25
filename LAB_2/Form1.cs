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

        private void InfoButton_Click(object sender, EventArgs e)
        {
            Form programmeInfoForm = new ProgrammeInfo();
            programmeInfoForm.Show();
            Hide();
        }

        private void Task1Button_Click(object sender, EventArgs e)
        {
            Form task1Form = new Task1();
            task1Form.Show();
            Hide();
        }
    }
}
