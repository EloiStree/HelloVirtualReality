using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchBomb : MonoBehaviour {

    public Transform m_rootOfThePlayer;
    public Transform m_userLookDirection;

    public Transform m_bombSpawn;
    public GameObject m_bombPrefab;


    public float m_bombImpluseForce=1;


    [Header("Debug (Do not touch))")]
    public int m_firedBomb;
  
	void Update () {

        if (OVRInput.GetDown(OVRInput.Button.Back) ||  Input.GetKeyDown(KeyCode.Space))  {
            GameObject bomb = GameObject.Instantiate(m_bombPrefab, m_bombSpawn.position, Quaternion.identity);
            Rigidbody rigBomb = bomb.GetComponent<Rigidbody>();
            rigBomb.AddForce(m_bombSpawn.forward * m_bombImpluseForce, ForceMode.Impulse);
            m_firedBomb++;
        }
        	
	}
}
