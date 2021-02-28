using System;
using System.Drawing;
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

        private void buttonAddPhoto_Click(object sender, EventArgs e)
        {
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Image Files(*.BMP; *.JPG; *.GIF)| *.BMP; *.JPG; *.GIF | All files(*.*) | *.*";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxPhotoFile.Text =  openFileDialog.FileName;
                pictureBoxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxPhoto.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
        private void buttonRegistration_Click(object sender, EventArgs e)
        {

        }
    }
}
