using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Application_Management
{
    public class MainFormManager : ApplicationContext
    {
        protected bool exitAppOnClose;

        public Form CurrentForm
        {
            get { return MainForm; }
            set
            {
                if (MainForm != null)
                {
                    // close the current form, but don't exit the application
                    exitAppOnClose = false;
                    MainForm.Close();
                    exitAppOnClose = true;
                }
                // switch to the new form
                MainForm = value;
                MainForm.Show();
            }
        }

        public MainFormManager()
        {
            exitAppOnClose = true;
        }

        // when a form is closed, don't exit the application if this is a swap
        protected override void OnMainFormClosed(object sender, EventArgs e)
        {
            if (exitAppOnClose)
            {
                base.OnMainFormClosed(sender, e);
            }
        }
    }
}
