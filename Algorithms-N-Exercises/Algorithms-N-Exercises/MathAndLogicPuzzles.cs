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

        // Given a positive integer n written as abcd... (a, b, c, d... being digits) and a positive integer p 
        // we want to find a positive integer k, if it exists, such as the sum 
        // of the digits of n taken to the successive powers of p is equal to k * n. 
        // 89 --> 8¹ + 9² = 89 * 1
        // 695 --> 6² + 9³ + 5⁴= 1390 = 695 * 2
        // 46288 --> 4³ + 6⁴+ 2⁵ + 8⁶ + 8⁷ = 2360688 = 46288 * 51
        // If it is the case we will return k, if not return -1.
        public static long digPow(int n, int p)
        {
            int countOfDigitsMinusOne = (int)Math.Log10(n);
            p = p + countOfDigitsMinusOne;
            int nk = 0;
            int N = n;
            while (N != 0)
            {
                int digit = N % 10;
                nk += (int)Math.Pow(digit, p);
                N /= 10;
                p--;
            }
            if (nk % n == 0)
                return nk / n;
            return -1;
        }
    }
}
