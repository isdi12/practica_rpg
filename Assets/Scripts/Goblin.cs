using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : Character
{
    public Goblin() : base("goblin", 5, Resources.Load<Sprite>("Sprites/goblin")) // construimos padre
    {

    }
    public override float Attack()
    {
        Debug.Log("goblin ataca");
        if (health < 20)
        {
            return damage * 3;
        }
        else
        {
            return damage;
        }
    }
       
        public override float Heal()
    {
        float restartLife; 
        Debug.Log("goblin se cura");
        restartLife = damage / 2;
        health += restartLife;
        base.Heal();
        return restartLife;
    }
}
