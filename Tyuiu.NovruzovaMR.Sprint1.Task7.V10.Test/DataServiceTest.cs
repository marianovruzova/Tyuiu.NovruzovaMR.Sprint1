using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NovruzovaMR.Sprint1.Task7.V10.Lib;

namespace Tyuiu.NovruzovaMR.Sprint1.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double wait = 1.027;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, Math.Round(res, 3));
        }
    }
}