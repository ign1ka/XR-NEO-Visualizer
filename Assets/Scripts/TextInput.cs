using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TextInput : MonoBehaviour, ISelectHandler
{
    private TouchScreenKeyboard overlayKeyboard;
    public static string inputText = "";
    
    public void OnSelect(BaseEventData eventData)
    {
        
        overlayKeyboard = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
        Debug.Log(overlayKeyboard);
        if (overlayKeyboard != null)
        {
            inputText = overlayKeyboard.text;
        }
        
    }
}
