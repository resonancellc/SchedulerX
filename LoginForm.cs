using SchedulerX.Factory;
using SchedulerX.Model;
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
        private LoginValidator _loginValidator;

        public LoginForm(IValidator loginValidator)
        {
            this._loginValidator = loginValidator as LoginValidator;
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            this._login = tb_login.Text;
            this._password = tb_password.Text;

            if (_loginValidator.IsValid(_login, _password))
            {
                IUser user = UserFactory.GetUserByLogin(_login);
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                // show error informing that inserted data was incorrect
            }
        }
    }
}
