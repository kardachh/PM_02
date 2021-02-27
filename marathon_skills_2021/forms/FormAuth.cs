using System;
using System.Windows.Forms;

namespace marathon_skills_2021.forms
{
    public partial class FormAuth : Form
    {
        public FormAuth()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            TimeSpan duration = Convert.ToDateTime("8.03.2021 6:00:00") - DateTime.Now;
            labelTimer.Text = duration.ToString("%d") + " days " + duration.ToString(@"hh\:mm\:ss");
        }
    }
}
