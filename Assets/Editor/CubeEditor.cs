using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Cube))]
public class CubeEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        Cube cube = (Cube)target;

        GUILayout.BeginHorizontal();

        if(GUILayout.Button("Change Position"))
        {
            cube.Movimiento();
        }

        if(GUILayout.Button("Reset Position"))
        {
            cube.Reset();
        }

        GUILayout.EndHorizontal();
    }
}
