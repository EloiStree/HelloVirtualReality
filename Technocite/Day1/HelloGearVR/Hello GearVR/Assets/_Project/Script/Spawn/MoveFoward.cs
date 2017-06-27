using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFoward : MonoBehaviour {

    [SerializeField]
    float m_speed = 0;

   



    public void SetSpeed (float speed) {
        m_speed = speed;
    }
    void Update () {
        transform.position += transform.forward * Time.deltaTime * m_speed;
	}

}
