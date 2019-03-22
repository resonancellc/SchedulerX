using SchedulerX.Factory;
using SchedulerX.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulerX
{
    public partial class LoginForm : Form
    {
        private string _login;
        private string _password;


        public LoginForm()
        {
            InitializeComponent();  
            lbl_login.Text = "dupa";
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this._login = tb_login.Text;
            this._password = tb_password.Text;

            LoginValidator loginValidator = ValidatorFactory.GetLoginValidator() as LoginValidator;
            bool isValid = loginValidator.IsValid();
        }
    }
}
