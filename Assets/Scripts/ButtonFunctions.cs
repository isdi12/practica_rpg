using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonFunctions : MonoBehaviour
{
   
    public void LoadScene(string sceneName)
    {
        GameManager.instance.LoadScene(sceneName);
    }
    
    public void SetName ()
    {
     GameManager.instance.SetName(FindObjectOfType<TMP_InputField>().text); 
    }
    
}
