using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.UleevRI.Sprint6.TaskReview.V12.Lib
{
    public class DataService
    {
        public int CalculateMatrix(int[,] num, int n1, int n2, int c, int k, int l)
        {
            int cnt = 0;
            int res = 0;
            for (int i = k; i < l + 1; i++)
            {
                if (cnt % 2 != 0) res += 1;
                cnt += 1;
            }
            return res;
        }
    }
}
