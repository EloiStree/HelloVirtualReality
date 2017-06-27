using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using UnityEngine.Events;

public class IsFocused
{

    [SerializeField]
    private bool _focus;
   
    public bool HasTheFocus
    {
        get { return _focus; }
        set {
            bool newValue= value, oldValue = _focus;
            _focus = value;
            if (newValue != oldValue)
            {
                if (newValue)
                    _onEnter.Invoke();
                else _onEnter.Invoke();

            }

        }
    }

    public float _focusedTime;

    public UnityEvent _onEnter;
    public UnityEvent _onExit;

    public void SetFocusTo(bool hasFocus) {
        HasTheFocus = hasFocus;
    }


    void Update() {
        if (HasTheFocus)
            _focusedTime += Time.deltaTime;
        else _focusedTime = 0;
    }
}