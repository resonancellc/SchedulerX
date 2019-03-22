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
        public static IUser GetUser()
        {
            return new User();
        }

        public static IUser GetUserByID(int id)
        {
            return new User();
        }
    }
}
