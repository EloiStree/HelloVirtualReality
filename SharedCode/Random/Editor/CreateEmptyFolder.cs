using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using System;

public class CreateEmptyFolder : MonoBehaviour {

    [MenuItem("Sophia / Create Empty Folder %&n")]
    public static void CreateEmpty() {
        var path = "";
        var obj = Selection.activeObject;
        if (obj == null) path = "Assets";
        else path = AssetDatabase.GetAssetPath(obj.GetInstanceID());
        if (path.Length > 0)
        {
            if (Directory.Exists(path))
            {
                Debug.Log("Folder" + path);
                Directory.CreateDirectory(path + "/NewFolder/");
                SelectFolder(path + "/NewFolder/");
            }
            else
            {
                FileInfo file = new FileInfo(path);
                
                Debug.Log("File"+ file.Directory);
                Directory.CreateDirectory(file.Directory + "/NewFolder/");
                SelectFolder(file.Directory + "/NewFolder/");
            }
        }
        else
        {
            Debug.Log("Not in assets folder");
        }
        AssetDatabase.Refresh();
    }

    private static void SelectFolder(string path)
    {
        string unityPath = Application.dataPath;
        unityPath = unityPath.Replace("/", "\\");
        path = path.Replace("/", "\\");
        path = path.Replace(unityPath, "");
        if(path[0] == '/' || path[0] == '\\')
        path = path.Substring(1);

        Debug.Log("Unity Path : " + unityPath);
        Debug.Log("Selected : " + path);
        // Load object
        UnityEngine.Object obj = AssetDatabase.LoadAssetAtPath(path, typeof(UnityEngine.Object));

        // Select the object in the project folder
        Selection.activeObject = obj;
        EditorGUIUtility.PingObject(obj);
        AssetDatabase.Refresh();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
