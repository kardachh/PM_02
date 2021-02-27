using System;
using System.Windows.Forms;

namespace marathon_skills_2021.forms
{
    public partial class FormWhatRunner : Form
    {
        private FormMarathon formMarathon;
        public FormWhatRunner(FormMarathon formMarathon)
        {
            InitializeComponent();
            this.formMarathon = formMarathon;
            timer_Tick(timer, null);
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
        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime end = Convert.ToDateTime("8.03.2021 6:00:00");
            DateTime time = DateTime.Now;
            TimeSpan duration = end - time;
            labelTimer.Text = duration.ToString("%d") + " days " + duration.ToString(@"hh\:mm\:ss");
        }

        private void FormWhatRunner_FormClosed(object sender, FormClosedEventArgs e)
        {
            formMarathon.Show();
        }
    }
}
