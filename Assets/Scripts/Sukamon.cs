using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sukamon : Character
{
    public Sukamon() : base("mbappe", 50 , Resources.Load<Sprite>("Sprites/mbappe")) // construimos padre
    {

    }
    public override float Attack()
    {
        Debug.Log("Mbappe ataca");
        if (health < 5)
        {
            return 100f;
        }
        else
        {
            return damage;
        }
    }

    public override float Heal()
    {
        float restartLife;
        Debug.Log("Mbappe se cura");
        restartLife = damage / 3f;
        health += restartLife;
        base.Heal();
        return restartLife;
    }
}
