﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NovruzovaMR.Sprint1.Task2.V28.Lib
{

    public class DataService : ISprint1Task2V28
    {
        public int ConvertCelsiusToKelvin(int value)
        {
            return (int)(value +273);
        }
    }
}