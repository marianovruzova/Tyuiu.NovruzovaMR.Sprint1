using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NovruzovaMR.Sprint1.Task2.V28.Lib;

namespace Tyuiu.NovruzovaMR.Sprint1.Task2.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExression()
        {
            DataService ds = new DataService();
            int x = 0;
            var res = ds.ConvertCelsiusToKelvin(x);
            Assert.AreEqual(+273, res);
        }
    }
}