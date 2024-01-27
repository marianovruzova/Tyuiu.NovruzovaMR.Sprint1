﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NovruzovaMR.Sprint1.Task7.V10.Lib
{
    public class DataService : ISprint1Task7V10
    {
        public double Calculate(double x)
        {
            double res = 2 * Math.Tan(3 * x) - ((Math.Log(Math.Cos(x))) / (Math.Log(1 + x * x)));
            return Math.Round(res, 3);
        }
    }
}