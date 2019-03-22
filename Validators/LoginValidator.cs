using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerX.Validators
{
    public class LoginValidator : IValidator
    {
        private string _login;
        private string _password;

        public bool Validate()
        {
            // check if there is any user with given password in database, if yes, return true

            return true;
        }

        public bool IsValid(string login, string password)
        {
            this._login = login;
            this._password = password;
            return Validate();
        }
    }
}
