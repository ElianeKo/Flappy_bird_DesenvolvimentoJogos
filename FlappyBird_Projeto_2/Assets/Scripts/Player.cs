using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 axis;
    public float gravity = -7f;
    public float force = 5f;
    public GameManager gameManager;
    

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    
    void Update()
    {
        axis.y += gravity * Time.deltaTime ;
        transform.position += axis * Time.deltaTime;
        //Ao Precionar a tecla espaço ou o botão do mouse o player sobe
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            axis = Vector2.up * force;
        }
    }

    private void OntriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Obstacles"))
        {
            gameManager.GameOver();
        }
        
        if(collision.CompareTag("Scoring"))
        {
            gameManager.Scoring();
        }
    }




}
