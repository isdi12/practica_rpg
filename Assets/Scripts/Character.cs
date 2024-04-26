using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character 
{
    public float health = 100;
    private string _name;
    private Sprite _sprite;
    protected float damage;

    public Character() { }
    public Character(string name, float damage, Sprite sprite) 
    {
        this._name = name;
        this.damage = damage;
        _sprite = sprite;
    }


    public Sprite GetSprite() 
    { 
        return _sprite; 
    }
    public float GetDamage()
    {
        return damage;
    }

    public string GetName() 
    { 
        return _name; 
    }
    public virtual float Heal()
    {
        Debug.Log("Character se cura");
        health = Mathf.Clamp(health, 0, 100);
        return health;    
    }
    public abstract float Attack();
}
