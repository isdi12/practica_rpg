using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Character character;
    private int life;
    private string selectName; 

    private void Awake()
    {

        // SINGLETON
        if (!instance) // si instance no tiene informacion
        {
            instance = this; // instance se asigna a este objeto
            DontDestroyOnLoad(gameObject); // se indica que este obj no se destruya con la carga de escenas
        }
        else // si instance tiene info
        {
            Destroy(gameObject); // se destruye el gameObject, para que no haya dos o mas gms en el juego
        }
    }
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        
    }
    public void SelectCharacter()
    {
        TMP_Dropdown dropdown = FindObjectOfType<TMP_Dropdown>();
        if (dropdown.value == 0)
        {
            character = new Cowboy (selectName);
        }
        else if (dropdown.value == 1)
        {
            character = new Wizard (2f , selectName);
        }
    }

    public string GetName()
    {
        return selectName; 
    }

    // setter
    public void  SetName (string selectName)
    {
        this.selectName = selectName;
    }
}
