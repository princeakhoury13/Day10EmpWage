﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10EmpWage
{
    public interface IEmpWage
    {
        public void addCompanyEmpWage(string company, int empRate, int workingDays, int maxHours);
        public void computeEmpWage();
        
    }
}
