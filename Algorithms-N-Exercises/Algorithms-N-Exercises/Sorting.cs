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

        public static void QuickSort(int[] arr)
        {
            QuickSortInner(arr, 0, arr.Length - 1);
        }

        private static void QuickSortInner(int[] arr, int left, int right)
        {
            if (left < right)
            {
                var pivot = Partition(arr, left, right);
                if (pivot > 1)
                {
                    QuickSortInner(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    QuickSortInner(arr, pivot + 1, right);
                }
            }
        }

        private static int Partition(int[] arr, int left, int right)
        {
            var pivot = arr[left];
            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    Swap(arr, left, right);
                }
                else
                {
                    return right;
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
