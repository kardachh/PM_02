using System;
using System.Windows.Forms;

namespace marathon_skills_2021.forms
{
    public partial class FormWhatRunner : Form
    {
        public FormWhatRunner()
        {
            InitializeComponent();
        }

        private void buttonShowRunner_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddNewRunner_Click(object sender, EventArgs e)
        {
            Form formAddRunner = new forms.FormAddRunner();
            formAddRunner.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
