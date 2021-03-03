using System;
using System.Windows.Forms;

namespace marathon_skills_2021.forms
{
    public partial class FormAuth : Form
    {
        private Form formPrev;
        public FormAuth(Form formPrev)
        {
            InitializeComponent();
            this.formPrev = formPrev;
            timer_Tick(timer, null);
        }
        private void FormAuth_FormClosed(object sender, FormClosedEventArgs e)
        {
            //buttonBack
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            TimeSpan duration = Convert.ToDateTime("8.03.2021 6:00:00") - DateTime.Now;
            labelTimer.Text = duration.ToString("%d") + " days " + duration.ToString(@"hh\:mm\:ss");
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Hide();
            if (formPrev.Name == "FormMarathon")
            {
                formPrev.Show();
            }
            else
            {
                formPrev = new FormMarathon();
                formPrev.Show();
            }
            Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "" && textBoxPassword.Text == "")
            {
                MessageBox.Show("Введите данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool key = false;
                foreach (data.User users in Program.marathonSkillsEntities.User)
                {
                    if (textBoxEmail.Text == users.Email && textBoxPassword.Text == users.Password)
                    {
                        key = true;
                        user.email = users.Email;
                        user.password = users.Password;
                        user.role = users.RoleId;
                    }
                }
                if (!key)
                {
                    MessageBox.Show("Проверьте данные", "Пользователь не найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxEmail.Text = "";
                    textBoxPassword.Text = "";
                }
                else
                {
                    MessageBox.Show("Вход выполнен!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (user.role == "R")
                    {
                        Hide();
                        FormRunnerMenu Runnermenu = new FormRunnerMenu(this);
                        Runnermenu.Show();
                    }
                    else if (user.role == "A")
                    {
                        Hide();
                        FormAdminMenu administratorMenu = new FormAdminMenu(this);
                        administratorMenu.Show();
                    }
                    else if (user.role == "C")
                    {
                        Hide();
                        FormCoordinatorMenu coordinatorMenu = new FormCoordinatorMenu(this);
                        coordinatorMenu.Show();
                    }
                }
            }
        }
        public struct Users
        {
            public string email;
            public string password;
            public string role;
        }
        public static Users user = new Users();
    }
}
