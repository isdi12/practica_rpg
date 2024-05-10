using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonFunctions : MonoBehaviour
{
   
    public void LoadScene(string sceneName)
    {
        GameManager.instance.LoadScene(sceneName); // para cambiar la escena 
    }
    
    public void SetName ()
    {
     GameManager.instance.SetName(FindObjectOfType<TMP_InputField>().text);  // para que salgan los nombres en el cowboy y wizard 
    }
    
}
