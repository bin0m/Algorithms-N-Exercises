using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_N_Exercises
{
    public class Sorting
    {
        // sort asc
        // 1 3 2 4
        public static void BubbleSort(int[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n; i++)
            {
                bool isSortedAlready = true;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        Swap(a, j, j + 1);
                        isSortedAlready = false;
                    }
                }
                if (isSortedAlready == true)
                {
                    break;
                }
            }
        }

        private static void Swap(int[] a, int i, int j)
        {
            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }
    }
}
