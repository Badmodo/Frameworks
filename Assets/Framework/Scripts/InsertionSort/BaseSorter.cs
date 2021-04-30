using Sorting.Visualization;
using System.Collections;
using UnityEngine;

namespace StatsFramework
{
    // Sort algorithm base class
    public abstract class BaseSorter : MonoBehaviour
    {
        protected Visualizer visualizer;
        protected Node[] nodes;

        void Start()
        {
            visualizer = Visualizer.Instance;
            nodes = visualizer.Nodes;
        }

        // Run sorting algorithm
        public void RunSorter()
        {
            StartCoroutine(SortAscending());
        }

        // Sorting coroutine
        protected abstract IEnumerator SortAscending();

        // Swap nodes at 2 indexes
        protected void SwapNodes(int indexA, int indexB)
        {
            Node temp = nodes[indexA];
            nodes[indexA] = nodes[indexB];
            nodes[indexB] = temp;
        }

        // Highlight node to blue color
        protected void HighlightNodeBlue(int _node, bool isHighlighted)
        {
            visualizer.HighlightNodeBlue(_node, isHighlighted);
            //visualizer.SetNodes(nodes);
        }

        // Highlight node to red color
        protected void HighlightNodeRed(int _node, bool isHighlighted)
        {
            visualizer.HighlightNodeRed(_node, isHighlighted);
            //visualizer.SetNodes(nodes);
        }

        // Tell visualizer to updata visuals
        protected void UpdateNodes ()
        {
            visualizer.SetNodes(nodes);
        }

        // Debug function for printing all node values
        protected void PrintNodes(int low, int high)
        {
            string log = "";
            for (int i = low; i <= high; i++)
            {
                log = log + "[" + i + "]  = " + nodes[i].Value + ", ";
            }
            Debug.Log(log);
        }
    }
}