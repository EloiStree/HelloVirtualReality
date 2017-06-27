using UnityEngine;
using System.Collections;


 namespace BlackBoxTools.VR{
public class RotateCameraWithMouse : MonoBehaviour {
    
    public Transform _target ;
    public Vector3 _rotateAround;
    public float _degreeBySecondHorizontal = 360;
    public float _degreeBySecondVertical = 180;

    public bool _allowToBeUsedInEditor = true;
    public bool _allowToBeUsedOutOfEditor = false;

    void Start() {
    }

    public bool AllowToRotate() {


        #if !UNITY_EDITOR
            return  _allowToBeUsedOutOfEditor;
        #endif
        return _allowToBeUsedInEditor;

    }
    void Update()
    {

        if (AllowToRotate()) { 
            _rotateAround.x += Input.GetAxis("Mouse X") * _degreeBySecondHorizontal * Time.deltaTime;
            _rotateAround.y += Input.GetAxis("Mouse Y") * _degreeBySecondVertical * Time.deltaTime;
            _rotateAround.y = Mathf.Clamp(_rotateAround.y, -90f, 90f);

        _target.localRotation = Quaternion.Euler(new Vector3(-_rotateAround.y, _rotateAround.x, 0));
        }
    }
        public void ResetDirection() {
            _rotateAround = Vector3.zero;
        }
    
}
}