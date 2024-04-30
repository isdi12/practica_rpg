using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CombatController : MonoBehaviour
{
    public KeyCode attackKey = KeyCode.Mouse0, healKey = KeyCode.Mouse1;
    public float playerDamage;
    public float enemyDamage;
    public Character character, enemy;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<PlayerMovement>().enabled = false; // esto lo hacemos para que al empezar el combate se desactive el playermovement
    }

    // Update is called once per frame
    void Update()
    {
        playerDamage += Time.deltaTime;
        enemyDamage += Time.deltaTime;

        if (playerDamage > 5f)
        {
            if (Input.GetKeyDown(attackKey))
            {
                float dmg = GameManager.instance.character.Attack();
                enemy.health -= dmg; // para que el enemigo sufra daño 
                playerDamage = 0;
            }
        }

        if (Input.GetKeyDown(healKey))
        {
            float vida = GameManager.instance.character.Heal();
            GameManager.instance.character.health += vida; // para que se sume la vida   
            playerDamage = 0;
        }

        if (enemyDamage > 10f)
        {
            int num = Random.Range(0, 2); // para coger un valor random de si ataca o no 
            if (num == 0)
            {
                float dmg = enemy.Attack();
                GameManager.instance.character.health -= dmg;
                enemyDamage = 0;
            }
            if (num == 1)
            {
                float vida = enemy.Heal();
                enemy.health += vida;
                enemyDamage = 0;
            }
        }
        if (enemy.health == 0)
        {
            GetComponent<PlayerMovement>().enabled = true; // para que al morir el enemigo vuelva el player movement 
            Destroy(this); // para que al morir el enemigo se destruya el combat controller y podamos salir de el volviendo al mundo real despues de estar puestisimos de fentanilo 
        }
    } 
}

