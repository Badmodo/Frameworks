using UnityEngine;
using Sorting.Visualization;
using System.Collections;

namespace StatsFramework
{
    // Holds the logic for the sorting algorithm insertion sort
    public class InsertionSort : BaseSorter
    {
        // Override the base sorting method with the current definition of sorting algorithm
        protected override IEnumerator SortAscending()
        {
            for (int i = 1; i < nodes.Length; i++)
            {
                Node currentNode = nodes[i];

                //Index of the left-most ancestor with a value greater than keyValue
                int leftMostIndex = i - 1; 

                while (leftMostIndex >= 0 && nodes[leftMostIndex].Value > currentNode.Value)
                {
                    //If ancestor is of higher value than current, then make ancester move up in index...
                    nodes[leftMostIndex + 1] = nodes[leftMostIndex];

                    HighlightNodeRed(leftMostIndex, true);
                    HighlightNodeBlue(leftMostIndex + 1, true);
                    UpdateNodes();
                    yield return null;
                    HighlightNodeRed(leftMostIndex, false);
                    HighlightNodeBlue(leftMostIndex + 1, false);

                    //lower the leftMostIndex
                    leftMostIndex--;
                }

                nodes[leftMostIndex + 1] = currentNode;

                //visualization
                HighlightNodeRed(i, true);
                HighlightNodeBlue(leftMostIndex + 1, true);
                UpdateNodes();
                yield return null;
                HighlightNodeRed(i, false);
                HighlightNodeBlue(leftMostIndex + 1, false);
            }
        }
    }
}