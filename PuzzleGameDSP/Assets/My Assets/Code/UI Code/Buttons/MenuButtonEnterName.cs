using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButtonEnterName : MonoBehaviour
{
    private TouchScreenKeyboard overlayKeyboard;
    public static string inputText = "";
    public InputField inputField;
    public bool buttonActive = false;
    void OnTriggerEnter(Collider entityTriggered)
    {
        if (entityTriggered.gameObject.tag == "Controller")
        {
            Debug.Log("OnScreenKeyboard Button pressed");
            if(buttonActive == false)
            {
               
                buttonActive = true;
                
                inputField.ActivateInputField();
                inputField.Select();
                
            }
            else
            {
                buttonActive = false;
                inputField.DeactivateInputField();
                inputText = inputField.text;
            }
            
           
                
        }
    }
    
}
