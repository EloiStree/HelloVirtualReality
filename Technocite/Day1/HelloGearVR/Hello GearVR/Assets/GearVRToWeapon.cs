using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearVRToWeapon : MonoBehaviour {

    public int currentRocket = 0;
    public GameObject[] _rocketPrefabs;
    public Transform _spawn;
    public Transform _cube;

    public RocketType [] _rocketInStock;
 
    [System.Serializable]
    public class RocketType {
        public int value;


    }
    public void OnValidate()
    {
        for (int i = 0; i < _rocketInStock.Length; i++)
        {
            if (_rocketInStock[i].value == 5)
                _rocketInStock[i].value = 0;
        }
    }

    void Update () {

        if (OVRInput.GetDown(OVRInput.Button.Back))
        {
            _cube.Rotate(new Vector3(10, 10, 10));
            ;
//            GameObject rocket = GameObject.Instantiate(_rocketPrefabs[currentRocket], _spawn.position, _spawn.rotation);
                  }
        if (OVRInput.GetDown(OVRInput.Button.DpadRight))
        {
            _cube.Rotate(new Vector3(-20, -20, -20));
        }
        

    }
}
