using System;
using System.Windows.Forms;

namespace marathon_skills_2021
{
    public partial class FormMarathon : Form
    {
        public static FormMarathon mainForm;
        public FormMarathon()
        {
            InitializeComponent();
            mainForm = this;
            timer_Tick(timer, null);
        }

        private void buttonRunner_Click(object sender, EventArgs e)
        {
            Form formWhatRunner = new forms.FormWhatRunner(this);
            Hide();
            formWhatRunner.Show();
        }

        private void buttonSponsor_Click(object sender, EventArgs e)
        {
            Form formSponsor = new forms.FormSponsor(this);
            Hide();
            formSponsor.Show();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            Form formAbout = new forms.FormAbout(this);
            Hide();
            formAbout.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Form formAuth = new forms.FormAuth(this);
            Hide();
            formAuth.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            TimeSpan duration = Convert.ToDateTime("8.03.2021 6:00:00") - DateTime.Now;
            labelTimer.Text = duration.ToString("%d") + " days " + duration.ToString(@"hh\:mm\:ss");
        }
    }
}
