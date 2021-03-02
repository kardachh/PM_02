using System;
using System.Windows.Forms;

namespace marathon_skills_2021.forms
{
    public partial class FormWhatRunner : Form
    {
        private Form formPrev;
        public FormWhatRunner(Form formPrev)
        {
            InitializeComponent();
            this.formPrev = formPrev;
            buttonBack.Text = "< " + formPrev.Text;
            buttonBack.AutoSize = true;
            timer_Tick(timer, null);
        }
        private void FormWhatRunner_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPrev.Show();
        }
        private void buttonShowRunner_Click(object sender, EventArgs e)
        {
            // need add login 
            // remove this >
            Form formRunnerMenu = new forms.FormRunnerMenu(this);
            Hide();
            formRunnerMenu.Show();
        }
        private void buttonAddNewRunner_Click(object sender, EventArgs e)
        {
            Form formAddRunner = new forms.FormAddRunner(this);
            Hide();
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
    }
}