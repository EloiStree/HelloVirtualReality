﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

[HelpURL("http://jams.center/help/")]
[AddComponentMenu("Bla bla script / Life")]
public class Life : MonoBehaviour {

    [MenuItem("Jams.Center / Create Emply Player")]
    public static void CreateEmptyPlayer() {

        GameObject player = new GameObject("Emply Player");
        Life  life = player.AddComponent<Life>();
        life.SetMaxLife(3);
        life.Full();
    }

    private void Full()
    {
        SetLife(_maxLife);
    }

    [Header("Params")]
    [SerializeField]
    private int _life;
   
    // [Range(1,200)]+/

    [SerializeField]
    [Tooltip("Max life must be sup of 0")]
    private int _maxLife;

    [System.Serializable]
    public class LifeChangeEVent : UnityEvent<int> { }
    [Header("Events")]

    [Tooltip("Triggered each time the life is changed")]
    public LifeChangeEVent _onLifeChange;
    [Tooltip("Triggered each time the life is set to zero from an other value")]
    public UnityEvent _onDeath;

    /// <summary>
    /// This methode is for setting the life of the user.
    /// </summary>
    /// <param name="value">Life of the user between 0 and maxlife </param>
    public void SetLife(int value) {
        #region CONTROL LIFE
        if (value > _maxLife)
            value = _maxLife;
        if (value < 0)
            value = 0;
        #endregion

        int oldValue = _life;
        int newValue = value;
        bool isLifeChange = oldValue != newValue;

        #region TRIGGER EVENT
        if (isLifeChange && _onLifeChange!=null)
            _onLifeChange.Invoke(newValue);
        
        if (_life == value && isLifeChange && _onDeath != null)
            _onDeath.Invoke();
        #endregion
        _life = value;
        
    }

    public void SetMaxLife(int life) {

        if (_maxLife < 1) _maxLife = 1;
        _maxLife = life;

    }


    // Use this for initialization
    void Start () {
        _life = -5;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnValidate()
    {

        SetMaxLife(_maxLife);
        SetLife(_life);
    }
}
