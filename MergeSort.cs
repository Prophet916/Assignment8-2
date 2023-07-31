using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8_2
{
    internal class MergeSort
    {
        public static void MergeSorted(int[] arr)
        {
            if (arr == null || arr.Length <= 1)
                return;

            int n = arr.Length;
            int[] temp = new int[n];
            MergeSortHelper(arr, temp, 0, n - 1);
        }

        private static void MergeSortHelper(int[] arr, int[] temp, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2; // Avoids potential overflow

                MergeSortHelper(arr, temp, left, mid);
                MergeSortHelper(arr, temp, mid + 1, right);

                Merge(arr, temp, left, mid, right);
            }
        }

        private static void Merge(int[] arr, int[] temp, int left, int mid, int right)
        {
            Array.Copy(arr, left, temp, left, right - left + 1);

            int i = left;
            int j = mid + 1;
            int k = left;

            while (i <= mid && j <= right)
            {
                if (temp[i] <= temp[j])
                {
                    arr[k] = temp[i];
                    i++;
                }
                else
                {
                    arr[k] = temp[j];
                    j++;
                }
                k++;
            }

            while (i <= mid)
            {
                arr[k] = temp[i];
                i++;
                k++;
            }
        }
    }
}
