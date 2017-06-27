using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class UIWorldDetectVR : MonoBehaviour
{

    void Update()
    {
       // if(Input.GetMouseButtonDown(0))
        RaycastWorldUI();
    }

    void RaycastWorldUI()
    {
  
            PointerEventData pointerData = new PointerEventData(EventSystem.current);

            pointerData.position = new Vector2( Screen.width / 2, Screen.height / 2); //Input.mousePosition;

            List<RaycastResult> results = new List<RaycastResult>();
            EventSystem.current.RaycastAll(pointerData, results);

            if (results.Count > 0)
            {
                //WorldUI is my layer name
                if (results[0].gameObject.layer == LayerMask.NameToLayer("WorldUI"))
                {
                    //IsFocused focus = results[0].gameObject.GetComponent<IsFocused>();
                    //if (focus!=null) 
                    //{
                        string dbg = "Root Element: {0} \n GrandChild Element: {1}";
                        //Debug.Log(string.Format(dbg, results[results.Count - 1].gameObject.name, results[0].gameObject.name));

                         BouListener listener =  results[0].gameObject.GetComponent<BouListener>();
                        if(listener != null)
                            listener.Bou();
                        results.Clear();
                
                    //}
                }

            }
    }
}