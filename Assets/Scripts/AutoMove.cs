using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoMove : MonoBehaviour
{
    public float moveSpeed; // Velocidade de movimentacao
    public float jumpingPower; // Pulo
    private valores valoresScript;
    private float DifficultyMod;

    [SerializeField] private Rigidbody2D rb;

    void Start()
    {
        if (rb == null)
        {
            rb = GetComponent<Rigidbody2D>();
        }
        valoresScript = FindFirstObjectByType<valores>();
        DifficultyMod = valoresScript.var2;
        moveSpeed = 15f - DifficultyMod;
        Debug.Log("Move Speed: " + moveSpeed);

    }

    void FixedUpdate()
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
                SceneManager.LoadSceneAsync(0);
                return;
            }
            else
                Debug.Log("Perdeu!");
                if(moveSpeed > 1)
                    valoresScript.var2++;
                SceneManager.LoadSceneAsync(2);
                return;
        }
    }
}



