using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//[ExecuteInEditMode]
public class PlayerHeadDirection : MonoBehaviour
{

    public Transform _playerCamera;
    public Life [] _livingPeople;
	// Use this for initialization
	void Start () {
   
		
	}

    public void Update()
    {
        Debug.DrawLine(_playerCamera.position, _playerCamera.position + _playerCamera.forward * 2f, Color.blue, 5f);
        Debug.DrawLine(_playerCamera.position, _playerCamera.position + _playerCamera.right * 2f, Color.red, 5f);
        Debug.DrawLine(_playerCamera.position, _playerCamera.position + _playerCamera.up * 2f, Color.green, 5f);
    }

    // Update is called once per frame
    void Reset () {

        _livingPeople =FindObjectsOfType<Life>();

        if (_playerCamera == null && Camera.main!=null)
            _playerCamera = Camera.main.transform;
        if (_playerCamera == null)
            _playerCamera = GetComponent<Camera>().transform;

    }

    public void OnDestroy()
    {
        
    }
    
}
