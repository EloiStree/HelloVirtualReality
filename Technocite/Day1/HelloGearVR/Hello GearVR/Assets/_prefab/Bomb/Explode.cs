using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour 
{

    #region Public Members
    public GameObject m_explosion;
	#endregion
	
	#region System
	
	void Awake () 
	{
		
	}
	
	void Start () 
	{
		
	}
	
	void Update () 
	{
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(m_explosion,transform.position,Quaternion.identity);
        Destroy(gameObject);
    }
    #endregion


    #region Main Methods
    #endregion

    #region Tools
    #endregion

    #region Private and Protected Members
    #endregion
}
