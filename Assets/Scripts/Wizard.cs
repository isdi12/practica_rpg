using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Wizard : Character
{
    private float damageMultiplier;

    public Wizard(float damageMultiplier, string name) : base(name,20,  Resources.Load<Sprite>("Sprites/wizard"))
    {
        
    }
    public override float Attack()
    {
        damage *= damageMultiplier; 
        return damage;
    }

    public override float Heal()
    {
        float restartLife;
        Debug.Log("wizard se cura");
        restartLife = Random.Range(damage, damage * damageMultiplier);
        base.Heal();
        return restartLife; 
    }
}
