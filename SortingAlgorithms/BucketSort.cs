using System;
using System.Collections.Generic;
using System.Text;

namespace Sort_Algorithms
{
    // Bucket sort is a sorting algorithm that breaks down a larger list into smaller lists, and sorts those lists before
    // Putting everything back into the larger overarching list.
    // Bucket sort is best used when the range and distribution of data is known. Depending on the range and distribution, it may be
    // better to break down the larger list into more or less buckets.
    // Since bucket sort relies on another sorting algorithm to sort the buckets, we're going to use a bubble sort
    // Efficiency:
    // Best case:   O(N+k); Where k is the number of buckets
    // Worst Case:  O(N^2); Because we'll be using a bubble sort to sort the individual buckets
    public static class BucketSort
    {
        //
        // Bucket sort an array of ints, returns a list of ints
        //
        public static int[] SortIntArray(int[] arr, int numBuckets)
        {
            // First we want to create a new Array of Lists of Int
            List<int>[] buckets = new List<int>[numBuckets];

            // We also need a result List to store the sorted result
            List<int> result = new List<int>();

            // initialize all lists in the list array
            for(int i = 0; i < buckets.Length; i++)
            {
                buckets[i] = new List<int>();
            }

            // depending on where the number falls in the arrange, divide up the original list into the buckets
            foreach(int num in arr)
            {
                int choice = num / numBuckets;
                buckets[choice].Add(num);
            }

            // Now we sort each bucket one at a time.
            foreach(List<int> list in buckets)
            {
                List<int> temp = BubbleSort.SortListInt(list);
                result.AddRange(temp);
            }

            return result.ToArray();
        }

        public static List<int> SortIntList(List<int> input, int numBuckets)
        {
            // Make a result array
            int[] result = new int[input.Count];

            // Also need a result list
            List<int> rList = new List<int>();

            // Use the array bucket sort that was already created
            result = SortIntArray(input.ToArray(), numBuckets);

            // add the result to the list and return the list
            rList.AddRange(result);

            return rList;
        }

        // Bubble sort using a List of ints as an argument, useful for importing this class to other projects without importing the bubble sort class

        //public static List<int> SortListInt(List<int> list)
        //{
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        for (int j = 0; j < list.Count; j++)
        //        {
        //            if (list[i] < list[j])
        //            {
        //                int temp = list[i];
        //                list[i] = list[j];
        //                list[j] = temp;
        //            }
        //        }
        //    }
        //    return list;
        //}
