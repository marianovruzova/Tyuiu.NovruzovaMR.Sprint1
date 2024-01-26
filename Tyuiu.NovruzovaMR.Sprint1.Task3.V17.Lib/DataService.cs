using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NovruzovaMR.Sprint1.Task3.V17.Lib
{
    public class DataService : ISprint1Task1V17
    {
        public double Calculate(double x, double y)
        {
            return x * y * (5 - x);
        }

        public bool ZeroCheck(double number)
        {
            throw new NotImplementedException();
        }
    }
}