using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Practice
{
    public class QuickSort_Implementation
    {
        public static void QuickSort(int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }
        public static void QuickSort(int[] array, int left, int right)
        {
            if (left >= right)
                return;

            int i = left;
            int j = right;
            int pivot = array[(left + right) / 2];

            while(i <= j)
            {
                while (array[i] < pivot)
                    i++;

                while (array[j] > pivot)
                    j--;

                if (i <= j)
                {
                    var temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;

                    i++;
                    j--;
                }
            }

            QuickSort(array, left, j);
            QuickSort(array, i, right);
        }
    }
}
