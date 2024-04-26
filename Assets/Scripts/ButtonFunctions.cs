using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFunctions : MonoBehaviour
{
   
    public void LoadScene(string sceneName)
    {
        GameManager.instance.LoadScene(sceneName);
    }

    
}
