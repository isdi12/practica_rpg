using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D _rb;
    private Vector2 _dir;
    private SpriteRenderer _spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>(); 
        _rb = GetComponent<Rigidbody2D>(); 
        _rb.gravityScale = 0;
        _spriteRenderer.sprite = GameManager.instance.character.GetSprite(); 
    }

    // Update is called once per frame
    void Update()
    {
        _dir=Vector2.zero; 
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            _dir = new Vector2(-1, _dir.y);
            
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            _dir = new Vector2(1, _dir.y);
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            _dir = new Vector2(_dir.x, 1);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            _dir = new Vector2(_dir.x, -1);
        }

    }

    private void FixedUpdate() 
    {
        _rb.velocity = new Vector2(speed, speed) * _dir; // para la velocidad 
    }

    private void OnDisable()
    {
        _rb.velocity = Vector2.zero;   // el ondisable sirve para que al apagarse el fixedupdate se ejecute esto 
    }
}
