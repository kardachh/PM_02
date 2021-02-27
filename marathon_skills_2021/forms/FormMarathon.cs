using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
