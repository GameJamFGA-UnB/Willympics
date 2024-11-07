using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveX;
    public float speed;
    public bool podeandar = true;
     // Adicione essa variável para controlar o movimento

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Verifica se o movimento está permitido antes de ler o input

        if (podeandar)
            moveX = Input.GetAxis("Horizontal");
        else moveX = 0;
    }

    void FixedUpdate()
    {

            Move();

    }

    void Move()
    {
        // Aplica a velocidade no eixo X
        rb.linearVelocity = new Vector2(moveX * speed, rb.linearVelocity.y);

        // Limita a posição x
        float clampedX = Mathf.Clamp(rb.position.x, -7.5f, 7.5f);
        rb.position = new Vector2(clampedX, rb.position.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "altere") podeandar=false;
    }
}
    