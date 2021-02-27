using System;
using System.Windows.Forms;

/*
    1)сделать таймер -
    2)дописать все кнопки -
    3)скрытие окна при открытии нового -
*/

namespace marathon_skills_2021
{
    public partial class FormMarathon : Form
    {
        public FormMarathon()
        {
            InitializeComponent();
        }

        private void buttonRunner_Click(object sender, EventArgs e)
        {
            Form formWhatRunner = new forms.FormWhatRunner();
            formWhatRunner.Show();
        }

        private void buttonSponsor_Click(object sender, EventArgs e)
        {

        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime end = Convert.ToDateTime("8.03.2021 6:00:00");
            DateTime time =  DateTime.Now;
            TimeSpan duration = end - time;
            labelTimer.Text = duration.ToString("%d")+" days "+duration.ToString(@"hh\:mm\:ss");
        }
    }
}
