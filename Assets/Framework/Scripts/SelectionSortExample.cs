using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FunkyTown
{
    public class SelectionSortExample : MonoBehaviour
    {
        static void Main(string[] args)
        {
            double[] unsortedList = { 10, 45, 13, 6, 8 };
            SelectionSort(unsortedList);
        }

        private static void SelectionSort(double[] unsortedList)
        {
            //index of the current minimum
            int MinIndex = 0;
            //temorary number for swaping into the minimum indwx
            double minimumValueFound = 0;

            //main index is now the current spot for main
            for (int MainIndex = 0; MainIndex < unsortedList.Length; MainIndex++)
            {
                //min index is now the current for main list
                MinIndex = MainIndex;

                //now runs through the reaminder to find next lowest value
                for (int RemainingIndex = MainIndex + 1; RemainingIndex < unsortedList.Length; RemainingIndex++)
                {
                    //move the index if it find a lower number into its space
                    if (unsortedList[RemainingIndex] < unsortedList[MinIndex])
                    {
                        //update the minimum
                        MinIndex = RemainingIndex;
                    }
                }

                //now we have the indsexc for the lowest number, to bwe swapped for the element in the lsit
                minimumValueFound = unsortedList[MinIndex];
                unsortedList[MinIndex] = unsortedList[MainIndex];
                unsortedList[MainIndex] = minimumValueFound;
            }
        }

        private void Start()
        {
            Debug.Log(" 10, 45, 13, 6, 8 ");
        }
    }
}