using Algorithms_Practice;
using System;

namespace Algorithms
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new[] { 1, 5, 0, 34, 3, 9, 192 };
            QuickSort_Implementation.QuickSort(numbers);

           foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
               
        }


        public int FindNonMinOrMax(int[] nums)
        {
            int index = 0;
            int any;
            int max;
            int min;
            if (nums[index] > nums[index + 1])
            {
                max = nums[index];
                min = nums[index + 1];
            }
            else
            {
                max = nums[index + 1];
                min = nums[index];
            }
            if (nums[index + 2] < max && nums[index + 2] > min)
            {
                any = nums[index + 2];
                return any;
            }
            else
            {
                index++;
                return FindNonMinOrMax(nums);
            }
            return -1;
        }
        public static int FindMaxElement(int[] array, int index, int max)
        {
            if (index < array.Length)
            {
                if (array[index] > max)
                {
                    max = array[index];
                }
                return FindMaxElement(array, index + 1, max);
            }
            else return max;
        }

        public static int Sum(int[] array, int startIndex)
        {
            if (startIndex < array.Length)
            {
                return array[startIndex] + Sum(array, startIndex + 1);
            }
            else
                return 0;
        }
        public static int SumArray(int[] array, int index)
        {
            if (index < array.Length - 1)
            {
                int sum = index;
                sum = array[index] + array[index + 1];
                index++;
                SumArray(array, index);
                return sum;
            }
            return -1;
        }
        public static void GetArrayItem(int[] array, int item)
        {
            if (item < array.Length)
            {
                Console.WriteLine(array[item]);
                item++;
                GetArrayItem(array, item);
            }
        }
        public static void GetReverseArray(int[] array, int lastIndex)
        {
            if (lastIndex >= 0)
            {
                Console.WriteLine(array[lastIndex]);
                lastIndex--;
                GetReverseArray(array, lastIndex);
            }
        }

        public static int FindSmallest(int[] array)
        {
            int smallest = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < smallest)
                {
                    smallest = array[i];
                }
            }
            return smallest;
        }

        public string[] SortPeople(string[] names, int[] heights)
        {
            for (int i = 0; i < heights.Length - 1; i++)
            {
                int maxIndex = i;
                for (int j = i + 1; j < heights.Length; j++)
                {
                    if (heights[j] > heights[maxIndex])
                    {
                        maxIndex = j;
                    }
                }
                int temp = heights[maxIndex];
                heights[maxIndex] = heights[i];
                heights[i] = temp;

                string tempString = names[maxIndex];
                names[maxIndex] = names[i];
                names[i] = tempString;
            }
            return names;
        }

        public static void DescendingSelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int maxIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] > array[maxIndex])
                    {
                        maxIndex = j;
                    }
                }
                int temp = array[maxIndex];
                array[maxIndex] = array[i];
                array[i] = temp;


            }
        }

    }
}