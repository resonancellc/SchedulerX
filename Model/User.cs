using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerX.Model
{
    public class User : IUser
    {
        public int ID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
