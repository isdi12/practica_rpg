using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class BushSpawner : MonoBehaviour
{

    public GameObject bush;
    public int width = 3; // esto es para que salgan 3 x 3 
    public int height = 3;
    private int num;
    private SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        sprite = bush.GetComponent<SpriteRenderer>();
        num = Random.Range(-10, 11); // para que salgan en una psicion aleatoria 
        for (int i = 0; i < height; ++i) // los for instancian las lineas y columnas
        {
            for (int j = 0; j < width; ++j)
            {
                Instantiate(bush, new Vector2((j + num) * sprite.bounds.size.x,(i + num) * sprite.bounds.size.y), Quaternion.identity); // instancia el arbusto , el bound size es para coger el tamaño exacto
            }
        }
    }

   
}
