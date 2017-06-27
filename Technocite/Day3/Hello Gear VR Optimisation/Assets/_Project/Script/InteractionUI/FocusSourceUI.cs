using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class FocusSourceUI : MonoBehaviour {

    public bool onlyWithMouseDown=true;

    void Update()
    {
        if(Input.GetMouseButtonDown(0) || !onlyWithMouseDown )
            RaycastWorldUI();
    }

    void RaycastWorldUI()
    {

        PointerEventData pointerData = new PointerEventData(EventSystem.current);

        pointerData.position = new Vector2(Screen.width / 2, Screen.height / 2); //Input.mousePosition;

        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(pointerData, results);

        if (results.Count > 0)
        {
            for (int i = 0; i < results.Count; i++)
            {
                if (results[i].gameObject.GetComponent<FocusListener>()) {
                    Button button = results[i].gameObject.GetComponent<Button>();
                    if (button)
                        button.onClick.Invoke();
                    break;
                }

            }
            results.Clear();
        }
    }
}
