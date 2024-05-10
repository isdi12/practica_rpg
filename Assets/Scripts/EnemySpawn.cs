using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class EnemySpawn : MonoBehaviour
{
    private GameObject prefabEnemy; 
    private void Awake()
    {
        prefabEnemy = Resources.Load<GameObject>("Prefabs/enemigo"); // para cargar el gameobject 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<PlayerMovement>() && Random.Range(0,10)== 1 && !collision.GetComponent<CombatController>())// para que al entrar en el trigger del arbusto spawnee el enemigo 
        {
            
            CombatController kc=collision.gameObject.AddComponent<CombatController>(); // para añadir el componente de combat controller al player 
            SelectCharacter(kc);
            GameObject obj = Instantiate(prefabEnemy, new Vector2  (collision.transform.position.x+5, collision.transform.position.y),Quaternion.identity); // para que aparezca el enemigo
            obj.GetComponent<SpriteRenderer>().sprite= kc.enemy.GetSprite();//para que coja el sprite correcto del enemigo
            kc.nemy = obj;
            obj.transform.localScale= new Vector3(0.3f, 0.3f, 0.3f); // con esto bajamos el tamaño del enemigo 
        }
    }
    private void SelectCharacter(CombatController combatController)
    {
        int num = Random.Range(0, 2); // random para coger un enemigo aleatorio
        switch(num)
        {
            case 0:
                combatController.enemy = new Sukamon(); // para que salga sukamon
                break;
            case 1:
                combatController.enemy = new Goblin(); // para que salga el goblin
                break;
            default:
                combatController.enemy = new Sukamon(); // por si hay una excepcion que salga sukamon
                break;
        }
    }
}
