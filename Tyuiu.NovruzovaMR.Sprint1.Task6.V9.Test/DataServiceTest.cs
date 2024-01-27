using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NovruzovaMR.Sprint1.Task6.V9.Lib;
namespace Tyuiu.NovruzovaMR.Sprint1.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string str = "world";
            DataService ds = new DataService();
            string res = ds.MoveLetterToStart(str);
            string wait = "orldw";
            Assert.AreEqual(wait, res);
        }
    }

}