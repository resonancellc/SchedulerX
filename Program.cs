using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchedulerX.Factory;
using SchedulerX.Validators;

namespace SchedulerX
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IValidator loginValidator = ValidatorFactory.GetLoginValidator();
            Application.Run(new LoginForm(loginValidator));
        }
    }
}
