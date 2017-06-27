using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCallSimulator : MonoBehaviour
{
    public static List<GameObject> Created = new List<GameObject>();
    public static int CreatedCount { get { return Created.Count; } }
    public GameObject   _prefabToCreate;
    public Material     _selectedMaterial;

    public Transform _whereToCreate;
    public float _creationRange;


    public bool _withSimpleSphere=true;
    public bool _withRandomColor;
    public bool _withTransparency;
    public bool _withSelectedMaterial;

    void Update () {

        if (Input.GetKeyDown(KeyCode.Escape)) {
            CreateRandomObject();
        }

        if (Input.GetMouseButton(0)) {
            CreateRandomObject();
        }	
	}

    private void CreateRandomObject()
    {
        Vector3 randomPos = RandomUtility.RandomInZone(_whereToCreate.position, _creationRange);
        
        GameObject obj = null;
        if (_withSimpleSphere ) {
            obj = Instantiate(GameObject.CreatePrimitive(PrimitiveType.Sphere), randomPos, Quaternion.identity);         }
        else obj = Instantiate(_prefabToCreate, randomPos, Quaternion.identity);

         if (_withRandomColor || _withSelectedMaterial) {
            Renderer ren = obj.GetComponent<Renderer>();
            if (_withSelectedMaterial && _selectedMaterial!=null)
                ren.material = new Material(_selectedMaterial);
            if (ren && ren.material)
                ren.material.color=  RandomUtility.GetRandomColor(_withTransparency);
        }
         
        if (obj != null)
        {
            Created.Add(obj);
            obj.name = CreatedCount + " :" + obj.name;
        }
    }

    public void DestroyCreated() {
        for (int i = 0; i < Created.Count; i++)
        {
            Destroy(Created[i]);
        }
        Created.Clear();
    }
}
