using System.Collections;
using UnityEngine;

namespace StatsFramework
{
    //class create an array
    public class SearchTest : MonoBehaviour
    {
        //setting the array
        [SerializeField] 
        //in array example, can be changed in editor
        int[] array = new int[] { 18, 45, 66, 105, 606};
        //this will be the target
        [SerializeField] 
        int target = 66;

        void Start()
        {
            //call the perform search function
            PerformSearch();
        }

        //the search test
        public void PerformSearch ()
        {
            string number = "";
            for (int i = 0; i < array.Length; i++)
            {
                number += array[i].ToString() + ", ";
            }
            //output into console
            Debug.Log("Array: " + number);

            int result = LinearSearch.IntSearch(array, target);
            //output into console
            Debug.Log($"Was the int {target} found " + (result == -1 ? "false" : "true"));
        }
    }
}
