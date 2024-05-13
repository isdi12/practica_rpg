using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Video;

public class CombatController : MonoBehaviour
{
    public KeyCode attackKey = KeyCode.Mouse0, healKey = KeyCode.Mouse1;
    public float playerDamage = 0f;
    public float enemyDamage = 0f;
    public Character character, enemy;
    private Interface interfaceComponent;
    public GameObject nemy;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<PlayerMovement>().enabled = false; // esto lo hacemos para que al empezar el combate se desactive el playermovement
        interfaceComponent = FindObjectOfType<Interface>(); // para buscar el objeto de la interfaz
        interfaceComponent.vidaEnemy(enemy); // para enseñar la vida del enemigo
    }

    // Update is called once per frame
    void Update()
    {
        interfaceComponent.vidaCharacter(); // enseñar vida del personaje
        playerDamage += Time.deltaTime; // temporizador del personaje (cooldown)
        enemyDamage += Time.deltaTime;  // temporizador del enemigo (cooldown)
        interfaceComponent.sliderCharacter(playerDamage); // para enseñar el slider 
        interfaceComponent.sliderEnemy(enemyDamage);    // para enseñar el slider 

        if (playerDamage > 5f) // ponemos el cooldown en un maximo de 5 
        {
            if (Input.GetKeyDown(attackKey))
            {
                float dmg = GameManager.instance.character.Attack(); // para llamar al daño del personaje desde el game manager y guardarlo
                enemy.health -= dmg; // para que el enemigo sufra daño 
                print("daño players " + dmg + " vida enemigo " + enemy.health);
                playerDamage = 0; // resetear el cooldown
                interfaceComponent.sliderCharacter(playerDamage); // para resetear el slider de la interfaz
                interfaceComponent.ataqueCharacter(dmg); // para enseñar el daño que hace el personaje
                interfaceComponent.vidaEnemy(enemy); // para enseñar la vida del enemigo 
            }
            if (Input.GetKeyDown(healKey))
            {
                float vida = GameManager.instance.character.Heal(); // llamamos a la vida del personaje desde el gamemanager y la guardamos
                playerDamage = 0; // resetear el cooldown
                interfaceComponent.sliderCharacter(playerDamage); // para resetar el slider de la interfaz 
                interfaceComponent.curarCharacter(vida); // para enseñar la vida que nos curamos 
                interfaceComponent.vidaCharacter(); // para enseñar la vida del personaje 
            }
        }



        if (enemyDamage > 10f)
        {
            int num = Random.Range(0, 2); // para coger un valor random de si ataca o no 
            if (num == 0) // si sale 0 el enemigo ataca 
            {
                float dmg = enemy.Attack(); // para llamar al daño del enemigo 
                GameManager.instance.character.health -= dmg; // para que al atacar el enemigo haga daño 
                enemyDamage = 0; // resetear el cooldown
                interfaceComponent.sliderEnemy(enemyDamage); // para resetar el slider de la interfaz 
                interfaceComponent.vidaEnemy(enemy); // para enseñar la vida del enemigo 
                interfaceComponent.ataqueEnemy(dmg); // para enseñar el daño que hace el enemigo

            }
            if (num == 1) // si sale 1 el enemigo se cura 
            {
                float vida = enemy.Heal();
                enemyDamage = 0;
                interfaceComponent.sliderEnemy(enemyDamage); // para resetar el slider de la interfaz 
                interfaceComponent.vidaEnemy(enemy);
                interfaceComponent.curarEnemy(vida); // para enseñar cuanto se cura el enemigo 
            }
        }
        if (enemy.health <= 0)
        {
            GetComponent<PlayerMovement>().enabled = true; // para que al matar al enemigo vuelva el componente del movimiento 
            Destroy(nemy); // para destruir el sprite del enemigo 
            Destroy(this); // para que al morir el enemigo se destruya el combat controller y podamos salir de el volviendo al mundo real despues de estar puestisimos de fentanilo 
        }

        if (GameManager.instance.character.health <= 0)
        {
            
            GameManager.instance.LoadScene("Menu");
        }
    }
}

