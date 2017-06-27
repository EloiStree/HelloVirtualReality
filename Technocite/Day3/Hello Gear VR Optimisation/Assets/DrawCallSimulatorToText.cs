using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawCallSimulatorToText : MonoBehaviour {

    public Text debugText;
	IEnumerator Start () {
        while (true) {
            if(debugText)
            debugText.text = ""+DrawCallSimulator.CreatedCount;
            yield return new WaitForSeconds(0.5f);
        }
        
	}
	
}
