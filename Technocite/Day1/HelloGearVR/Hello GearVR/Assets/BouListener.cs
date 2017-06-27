using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BouListener : MonoBehaviour {


    public UnityEvent m_onClick;
	// Use this for initialization
	public void Bou () {
      //  print("Bouhh Tu as eu peur ^^");
        m_onClick.Invoke();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
