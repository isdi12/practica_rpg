using System.Collections;
using System.Collections.Generic;
using Unity.Jobs;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public abstract class Character 
{
    public float health = 100;
    private string _name;
    private Sprite _sprite;
    protected float damage;

    public Character() { }
    public Character(string name, float damage, Sprite sprite) // para que todos los hijos del character tengan nombre daño y un sprite 
    {
        this._name = name; 
        this.damage = damage;
        _sprite = sprite;
    }


    public Sprite GetSprite() // el metodo que aparecera en los hijos para los sprites  
    { 
        return _sprite; 
    }
    public float GetDamage()  // el metodo que aparecera en los hijos para el daño 
    {
        return damage;
    }

    public string GetName() // el metodo que aparecera en los hijos para el nombre 
    
    { 
        return _name; 
    }
    public virtual float Heal() //el metodo que aparecera en los hijos para la vida 
    
    {
        Debug.Log("Character se cura");
        health = Mathf.Clamp(health, 0, 100);  // lo clampeamos para que al curarse no sobrepase los 100 de vida 
        return health;    
    }
    public abstract float Attack(); // un metodo abstracto que no esta definido en la clase padre y que fuerzas a la clase hija 
}
