using System;
using System.Windows.Forms;

namespace marathon_skills_2021
{
    static class Program
    {
        public static data.MarathonEntities marathonSkillsEntities = new data.MarathonEntities();
        
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new FormMarathon());
        }
        
    }
}
