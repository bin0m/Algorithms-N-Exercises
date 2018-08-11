using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_N_Exercises
{
    public class MathAndLogicPuzzles
    {
        //Sqrt(x,n)
        // time: O((logx)*(logn))
        public static double RootOfNumber(double x, int n)
        {
            double low = 0;
            double high = Math.Max(1, x);

            double mid = (low + high) / 2;
            while (low < high)
            {
                double p = Math.Pow(mid, n);
                if (Math.Abs(p-x) < 0.001)
                {
                    break;
                }
                if (p < x)
                {
                    low = mid;
                }
                else
                {
                    high = mid;
                }
                mid = (low + high) / 2;
            }

            return Math.Round(mid, 2);
        }
    }
}
