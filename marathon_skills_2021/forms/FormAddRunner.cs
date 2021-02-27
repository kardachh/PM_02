using System;
using System.Windows.Forms;

namespace marathon_skills_2021.forms
{
    public partial class FormAddRunner : Form
    {
        private Form formPrev;
        public FormAddRunner(Form formPrev)
        {
            InitializeComponent();
            this.formPrev = formPrev;
            buttonBack.Text = "< " + formPrev.Text;
            buttonBack.AutoSize = true;
            timer_Tick(timer, null);
        }
        private void FormAddRunner_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPrev.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            TimeSpan duration = Convert.ToDateTime("8.03.2021 6:00:00") - DateTime.Now;
            labelTimer.Text = duration.ToString("%d") + " days " + duration.ToString(@"hh\:mm\:ss");
        }
    }
}
