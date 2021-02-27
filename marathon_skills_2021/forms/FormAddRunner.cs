using System;
using System.Windows.Forms;

namespace marathon_skills_2021.forms
{
    public partial class FormAddRunner : Form
    {
        public FormAddRunner()
        {
            InitializeComponent();
            timer_Tick(timer, null);
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
    }
}
