using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Interface : MonoBehaviour
{

    public TMP_Text textComponent_playerLife, textComponent_playerInfo;
    
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void vidaCharacter()  
    {
        textComponent_playerLife.text = "name personaje " + GameManager.instance.character.GetName()+ "\n" +
            "vida personaje " + GameManager.instance.character.health.ToString();
        
    }

    public void ataqueCharacter(float dmg) 
    {
        textComponent_playerInfo.text = "atacar personaje " + dmg.ToString();

    }

    //public void curarCharacter(float cura) 
    //{
    //    textComponent.text = "curar personaje " + cura.ToString();
       
    //}

    
    //public void vidaEnemy()
    //{
    //    textComponent.text = "vida enemigo " + GameManager.instance.character.health.ToString();

    //}

    //public void ataqueEnemy()
    //{
    //    textComponent.text = "atacar enemigo " + GameManager.instance.character.GetDamage();

    //}

    //public void curarEnemy()
    //{
    //    textComponent.text = "curar enemigo " + GameManager.instance.character.Heal();

    //}

    public void nameEnemy()
    {

    }
}
