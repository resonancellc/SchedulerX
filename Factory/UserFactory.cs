using SchedulerX.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerX.Factory
{
    public static class UserFactory
    {
        public static IUser CreateUser()
        {
            return new User();
        }

        public static IUser GetUserByID(int id)
        {
            // create some logic that retrieves specific user from database
            return new User();
        }

        public static IUser GetUserByLogin(string login)
        {
            // create some logic that retrieves specific user from database
            return new User();
        }
    }
}
