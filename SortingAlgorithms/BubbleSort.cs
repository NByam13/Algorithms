using System;
using System.Collections.Generic;
using System.Collections;

namespace Sort_Algorithms
{
    public static class BubbleSort
    {
        public static List<int> SortListInt(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[i] < list[j]) // This will ensure the values are listed in ascending order
                    {
                        int temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
            return list;
        }
    }
}
