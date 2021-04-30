using UnityEngine;
using UnityEditor;

namespace StatsFramework
{
    [CustomEditor(typeof(SearchTest))]
    public class SearchTestEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            GUILayout.BeginHorizontal();
            SearchTest searchTest = (SearchTest)target;

            if (GUILayout.Button("See if there is a matching number?"))
            {
                searchTest.PerformSearch();
            }

            GUILayout.EndHorizontal();
        }
    }
}