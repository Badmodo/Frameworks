using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FunkyTown
{
    public class SearchAlgorythim : MonoBehaviour
    {
        private void Update()
        {
            List<int> cash = new List<int> { 60, 255, 185, 32, 15, 199 };
            cash.ForEach(Console.WriteLine);

        }
    }
}