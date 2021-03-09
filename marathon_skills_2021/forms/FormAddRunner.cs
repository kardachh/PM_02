using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
            ShowCountry();
            ShowGender();
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
                textBoxPhotoFile.Text = openFileDialog.FileName;
                pictureBoxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxPhoto.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxFirstName.Text != "" && textBoxEmail.Text != "" && textBoxPassword.Text != "" &&
                    textBoxConfirmPassword.Text != "" && textBoxLastName.Text != "" && comboBoxGender.SelectedItem != null &&
                    comboBoxCountry.SelectedItem != null && dateTimePickerDOB.Value != null)
                {
                    if (PasswordCheck() && EmailCheck())
                    {
                        data.Runner runner = new data.Runner();
                        data.User user = new data.User();
                        user.Email = textBoxEmail.Text;
                        user.Password = textBoxPassword.Text;
                        user.FirstName = textBoxFirstName.Text;
                        user.LastName = textBoxLastName.Text;
                        user.RoleId = "R";
                        runner.Email = textBoxEmail.Text;
                        runner.Gender = comboBoxGender.SelectedItem.ToString();
                        runner.DateOfBirth = dateTimePickerDOB.Value;
                        runner.CountryCode = comboBoxCountry.SelectedItem.ToString();
                        //Program.marathonSkillsEntities.Runner.Add(runner);
                        //Program.marathonSkillsEntities.User.Add(user);
                        //Program.marathonSkillsEntities.SaveChanges();
                        FormAuth.user.email = user.Email;
                        FormAuth.user.password = user.Password;
                        FormAuth.user.role = user.RoleId;
                        forms.FormRegistrationOnMarathon formRegistrationOnMarathon= new forms.FormRegistrationOnMarathon(this);
                        this.Hide();
                        formRegistrationOnMarathon.Show();
                    }
                }
                else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        private bool PasswordCheck()
        {
            if (textBoxPassword.Text != textBoxConfirmPassword.Text)
            {
                MessageBox.Show("Пароли не совпадают!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }
        private bool EmailCheck()
        {
            Regex emailRegex = new Regex(@"\w{2,10}@\w{2,10}.\w{2,10}");
            Match emailMatch = emailRegex.Match(textBoxEmail.Text);

            if (emailMatch.Value == "")
            {
                MessageBox.Show("Некорректный формат email!", "Оповещение системы");
                return false;
            }
            else return true;
        }
        void ShowGender()
        {
            comboBoxGender.Items.Clear();
            foreach (data.Gender Gender in Program.marathonSkillsEntities.Gender)
            {
                string[] item = { Gender.Gender1 };
                comboBoxGender.Items.Add(string.Join(" ", item));
            }
        }
        void ShowCountry()
        {
            comboBoxCountry.Items.Clear();
            foreach (data.Country country in Program.marathonSkillsEntities.Country)
            {
                string[] item = { country.CountryCode };
                comboBoxCountry.Items.Add(string.Join(" ", item));
            }
        }
    }
}
