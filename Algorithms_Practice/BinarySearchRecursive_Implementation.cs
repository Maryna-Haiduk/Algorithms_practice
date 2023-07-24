using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class BinarySearchRecursive_Implementation
    {
        public int BinarySearchRecursive(int[] a, int t)
        {
            return BinarySearchRecursive(a, 0, a.Length - 1, t);
        }

        public int BinarySearchRecursive(int[] array, int min, int max, int t)
        {
            int mid = (min + max) / 2;

            if (array[mid] == t)
                return mid;

            if (array[mid] > t)
            {
                return BinarySearchRecursive(array, min, mid - 1, t);
            }

            if (max < min)
            {
                return -1;
            }

            return BinarySearchRecursive(array, mid + 1, max, t);
        }
    }
}

