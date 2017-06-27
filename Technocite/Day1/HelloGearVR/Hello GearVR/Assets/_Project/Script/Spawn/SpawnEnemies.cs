using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{

   
    #region Public Members
    public Vector3 m_rightLimit;
    public Vector3 m_leftLimit;
    public Vector3 m_topLimit;

    [Range(0f, 10f)]
    public float m_timeToSpawn = 1f;
    public float m_enemySpeed = 2f;

    public GameObject m_enemyModel;
    public bool m_canSpawn = true;

    #endregion

    #region System

    // Use this before Start()
    void Awake()
    {

    }

    

    void Update()
    {
        if (m_canSpawn)
        {
            IEnumerator coroutine = CanSpawn();
            Vector3 spawnPosition = Vector3.zero;
            spawnPosition.x = Random.Range(m_leftLimit.x, m_rightLimit.x);
            spawnPosition.z = m_topLimit.z;
            GameObject go = Instantiate(m_enemyModel, spawnPosition, Quaternion.identity);
            MoveFoward moveScript =  go.AddComponent<MoveFoward>();
            moveScript.SetSpeed(m_enemySpeed);
            //Rigidbody rb = go.GetComponent<Rigidbody>();
            //rb.AddForce(go.transform.forward * -1);
        }
    }

    #endregion

    #region Main Methods

    private IEnumerator CanSpawn()
    {
        m_canSpawn = false;
        yield return new WaitForSeconds(m_timeToSpawn);
        m_canSpawn = true;
    }

    #endregion

    #region Tools

    #endregion

    #region Private - Protected Members

    #endregion


}