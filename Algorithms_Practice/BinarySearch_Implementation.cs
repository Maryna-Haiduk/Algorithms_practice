using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class BinarySearch_Implementation
    {
        private int BinarySearch(int[] array, int item)
        {
            Array.Sort(array);

            int left = 0;
            int right = array.Length - 1;

            if (array[left] == item)
            { return left; }
            else if (array[right] == item)
            { return right; }

            while (left <= right)
            {
                var midle = (left + right) / 2;

                if (array[midle] == item)
                { return midle; }

                if (item < array[midle])
                {
                    right = midle - 1;
                }
                else if (item > array[midle])
                {
                    left = midle + 1;
                }
            }

            return -1;
        }
    }
}