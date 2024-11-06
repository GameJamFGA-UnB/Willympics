using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove : MonoBehaviour
{
    public float moveSpeed; // Velocidade de movimentacao
    public float jumpingPower; // Pulo

    [SerializeField] private Rigidbody2D rb;

    void Start()
    {
        if (rb == null)
        {
            rb = GetComponent<Rigidbody2D>();
        }
        moveSpeed = 4f;
        Debug.Log("Move Speed: " + moveSpeed);

    }

    void Update()
    {
        rb.linearVelocity = new Vector2(moveSpeed, rb.linearVelocity.y); // Move 
    }

    private void OnCollisionEnter2D(Collision2D collision) // Funcao chamada em colisao
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "End"){ // Caso a colisao seja com o fim
            if(Ui.instance.steps<=0){ 
                Debug.Log("Ganhou!");
                jumpingPower = 10f;
                moveSpeed = 2f;
                rb.freezeRotation = true; // Tranca a rotacao do personagem
                rb.linearVelocity = new Vector2(moveSpeed, jumpingPower);
            }
            else
                Debug.Log("Perdeu!");
        }
    }
}



