using UnityEditor;
using UnityEngine;

public class PositionEditor : EditorWindow
{
    [MenuItem("Window/Movimiento")]
    public static void ShowWindow()
    {
        GetWindow<PositionEditor>("Movimiento");
    }
    private void OnGUI()
    {
        GUILayout.Label("Move the figures!", EditorStyles.boldLabel);

        if (GUILayout.Button("Move!"))
        {
            foreach(GameObject obj in Selection.gameObjects)
            {
                Transform posicion = obj.GetComponent<Transform>();

                obj.GetComponent<Transform>().position = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10));
            }
        }

        if (GUILayout.Button("Reset!"))
        {
            foreach(GameObject obj in Selection.gameObjects)
            {
                obj.GetComponent<Transform>().position =  new Vector3(0,0,0);
            }
        }
    }


}
