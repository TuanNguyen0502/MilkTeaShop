using Job_Application_Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace MilkTeaShop
{
    internal static class Program
    {
        private static MainFormManager mainFormManager;

        public static MainFormManager MainFormManager
        {
            get { return mainFormManager; }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            /*mainFormManager = new MainFormManager();
            mainFormManager.CurrentForm = new FLogin_User();
            Application.Run(mainFormManager);*/

            Application.Run(new FIngredient());
        }
    }
}
