using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Wizard : Character
{
    private float damageMultiplier;

    public Wizard(float damageMultiplier, string name) : base(name,20,  Resources.Load<Sprite>("Sprites/wizard"))
    {
        this.damageMultiplier = damageMultiplier; // creamos el wizard con los metodos recibidos y los de la clase padre
    } 
    public override float Attack() // para que ataque el mago 
    {
        return damage * damageMultiplier; // multiplica el daño 
    }

    public override float Heal() // para que se cure 
    {
        float restartLife; // para restuarar la vida 
        Debug.Log("wizard se cura");
        restartLife = Random.Range(damage, damage * damageMultiplier); // lo que restaurara de vida 
        health += restartLife; // suma a la vida total 
        base.Heal(); // para comprobar que no pase de 100
        return restartLife;  // devuelve lo que restaura de vida 
    }
}
