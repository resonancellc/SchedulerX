﻿using SchedulerX.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerX.Factory
{
    public static class ValidatorFactory
    {
        public static IValidator GetLoginValidator()
        {
            return new LoginValidator();
        }
    }
}
