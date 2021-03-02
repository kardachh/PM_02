using System;
using System.Windows.Forms;

namespace marathon_skills_2021.forms
{
    public partial class FormSponsor : Form
    {
        private Form formPrev;
        public FormSponsor(Form formPrev)
        {
            InitializeComponent();
            this.formPrev = formPrev;
            buttonBack.Text = "< " + formPrev.Text;
            buttonBack.AutoSize = true;
            timer_Tick(timer, null);
            ShowRunners();
        }
        private void FormSponsor_FormClosed(object sender, FormClosedEventArgs e)
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

        private void buttonPay_Click(object sender, EventArgs e)
        {
            data.Sponsorship sponsorship = new data.Sponsorship();
            try
            {
                if (textBoxName.Text != "" && textBoxCard.Text != "" &&
                    textBoxCardOwner.Text != "" && textBoxCVC.Text != "" && textBoxMonthCard.Text != "" &&
                    textBoxYearCard.Text != "" && comboBoxRunner.SelectedItem != null){
                    sponsorship.SponsorName = textBoxName.Text;
                    sponsorship.Amount = Convert.ToInt32(textBoxCash.Text);
                    //  Program.marathonSkillsEntities.Sponsorship.Add(sponsorship);
                    //  Program.marathonSkillsEntities.SaveChanges();
                    string[] info = { comboBoxRunner.SelectedItem.ToString(), textBoxName.Text, textBoxCash.Text };
                    FormSponsorConfirm formSponsorConfirm = new forms.FormSponsorConfirm(this,info);
                    Hide();
                    formSponsorConfirm.Show();
                }
                else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            { MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        void ShowRunners()
        {
            comboBoxRunner.Items.Clear();
            foreach (data.Runner runnerSet in Program.marathonSkillsEntities.Runner)
            {
                string[] item = { runnerSet.RunnerId.ToString() + ".", runnerSet.User.FirstName + " " + runnerSet.User.LastName };
                comboBoxRunner.Items.Add(string.Join(" ", item));
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            int cash = Convert.ToInt32(textBoxCash.Text);
            if (cash >= 10) textBoxCash.Text = (int.Parse(textBoxCash.Text) - 10).ToString();
            else
            { MessageBox.Show("Сумма не может быть меньше 0!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            labelAmount.Text = "$" + textBoxCash.Text;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            textBoxCash.Text = (double.Parse(textBoxCash.Text) + 10).ToString();
            labelAmount.Text = "$" + textBoxCash.Text;
        }
    }
}
