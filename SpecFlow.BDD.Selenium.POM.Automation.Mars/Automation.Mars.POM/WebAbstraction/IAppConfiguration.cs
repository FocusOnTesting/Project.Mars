﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Mars.POM.WebAbstraction
{
    public interface IAppConfiguration
    {
        public string GetConfiguration(string key);
    }
}
