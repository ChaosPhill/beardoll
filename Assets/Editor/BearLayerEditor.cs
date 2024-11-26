using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(BearLayersManager))]
public class BearLayerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        BearLayersManager manager = (BearLayersManager)target;

        if (GUILayout.Button("Sort Layer Order"))
        {
            manager.ResetSorting();
        }
        
        DrawDefaultInspector();
    }
}
