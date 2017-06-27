using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeftToRightMove : MonoBehaviour {

    public Transform m_target;

    public Transform m_leftLimit;
    public Transform m_rightLimit;

    [Header("Debug")]
    public Text m_debugAccelerometer;
    [Range(-1f,1f)]
    public float m_leftToRight;    


    void Update () {

        m_debugAccelerometer.text = ""+Input.acceleration;
        float xOfAccelormeter = 0;
#if UNITY_EDITOR
        xOfAccelormeter = m_leftToRight;
#elif UNITY_ANDROID
        xOfAccelormeter = Input.acceleration.x;
#endif
        Vector3 objectPosition;
        Vector3 direction = m_rightLimit.position - m_leftLimit.position;
        float pourcentOnTheRoad = (xOfAccelormeter + 1f) / 2f;

        objectPosition = m_leftLimit .position + direction * pourcentOnTheRoad;
        m_shouldBePosition  = objectPosition;

        m_target.position=  Vector3.Lerp(m_target.position, m_shouldBePosition, Time.deltaTime*2f);

    }

    private Vector3 m_shouldBePosition;

}
