using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatsFramework
{
    public static class LinearSearch
    { 
        //seach within an array
        public static int IntSearch (int[] data, int element)
        {
            //search each element to find the target
            for (int i = 0; i < data.Length; i++)
                if (data[i] == element)
                    return i;
            return -1;
        }
    }
}
