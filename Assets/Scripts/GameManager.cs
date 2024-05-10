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
    public void SelectCharacter() // para seleccionar el personaje
    {
        TMP_Dropdown dropdown = FindObjectOfType<TMP_Dropdown>();  // buscamos el valor del dropdown 
        if (dropdown.value == 1) // si es 1 se crea cowboy
        {
            character = new Cowboy (selectName);
        }
        else if (dropdown.value == 2) // si es 2 el wizard
        {
            character = new Wizard (2f , selectName);
        }
    }

    public string GetName() // para coger el nombre 
    {
        return selectName; 
    }

    // setter
    public void  SetName (string selectName) // para dar el nombre 
    {
        this.selectName = selectName;
    }
}
