using System;
using System.Windows.Forms;

namespace marathon_skills_2021
{
    static class Program
    {
        public static data.MarathonSkillsEntities RBS_Project = new data.MarathonSkillsEntities();
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMarathon());
        }
    }
}
