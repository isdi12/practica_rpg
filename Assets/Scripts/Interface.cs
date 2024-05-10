using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Interface : MonoBehaviour
{

    public TMP_Text textComponent_playerLife, textComponent_playerInfo, textComponent_enemyLife, textComponent_enemyInfo;
    public Slider sliderPlayer, sliderEnemigo;


    public void vidaCharacter()
    {
        textComponent_playerLife.text = "name personaje " + GameManager.instance.character.GetName() + "\n" + // enseña por pantalla el nombre y la vida del personaje
            "vida personaje " + GameManager.instance.character.health.ToString(); 
         
    }

    public void ataqueCharacter(float dmg)
    {
        textComponent_playerInfo.text = "atacar personaje " + dmg.ToString(); // enseña por pantalla el ataque del personaje

    }

    public void curarCharacter(float cura)
    {
        textComponent_playerInfo.text = "curar personaje " + cura.ToString(); // enseña por pantalla la curación del personaje

    }


    public void vidaEnemy(Character enemy)
    {
        textComponent_enemyLife.text = "name enemigo " + enemy.GetName() + "\n" + "vida enemigo " + enemy.health.ToString();  // enseña por pantalla el nombre y la vida del enemigo
    }

    public void ataqueEnemy(float dmg)
    {
        textComponent_enemyInfo.text = "atacar enemigo " + dmg; // enseña por pantalla el ataque del enemigo

    }

    public void curarEnemy(float cura)
    {
        textComponent_enemyInfo.text = "curar enemigo " + cura; // enseña por pantalla la curación del enemigo


    }

    public void sliderCharacter(float time)
    {
        sliderPlayer.value = time; // enseña por pantalla el cooldown del personaje
    }

    public void sliderEnemy(float time)
    {
        sliderEnemigo.value = time; // enseña por pantalla el cooldown del enemigo
    }
}
