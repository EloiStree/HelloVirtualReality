using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExempleInteractionGearVR : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //Pousser sur le bouton escape
        if (Input.GetKeyDown(KeyCode.Escape)) {

        }

        //Presser le pad
        if (Input.GetMouseButton(0)) {

        }

        //
        Vector2 screenPosition = Input.mousePosition;
        

	}

    public Vector2 startPressingPosition;
    public Vector2 lastPressingPosition;
}
