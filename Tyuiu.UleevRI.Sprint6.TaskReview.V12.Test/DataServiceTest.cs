using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UleevRI.Sprint6.TaskReview.V12.Lib;

namespace Tyuiu.UleevRI.Sprint6.TaskReview.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();
            int[,] num = new int[5, 5]
            {{1, 1, 2, 3, 6},
             {4, 1, 1, 5, 7 },
             {5, 6, 1, 1, 8 },
             {8, 5, 9 ,1, 9 },
             {2, 3, 1 ,1, 5 },
            };
            int res = ds.CalculateMatrix(num, 1, 9, 0, 0, 4);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}
