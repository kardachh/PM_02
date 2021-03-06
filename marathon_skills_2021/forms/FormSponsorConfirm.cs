﻿using System;
using System.Windows.Forms;

namespace marathon_skills_2021.forms
{
    public partial class FormSponsorConfirm : Form
    {
        private Form formPrev;
        public FormSponsorConfirm(Form formPrev, string[] info)
        {
            InitializeComponent();
            this.formPrev = formPrev;
            labelRunner.Text = info[0];
            labelCash.Text = "$" + info[2];
            labelCharity.Text = info[1];
            buttonBack.Text = "< " + formPrev.Text;
            buttonBack.AutoSize = true;
            timer_Tick(timer, null);
        }
        private void FormAuth_FormClosed(object sender, FormClosedEventArgs e)
        {
            buttonBack.PerformClick();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            TimeSpan duration = Convert.ToDateTime("8.03.2021 6:00:00") - DateTime.Now;
            labelTimer.Text = duration.ToString("%d") + " days " + duration.ToString(@"hh\:mm\:ss");
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Hide();
            FormMarathon.mainForm.Show();
            Close();
        }
    }
}
