using UnityEngine;

public class TriangleScript : MonoBehaviour
{
    public TriangleGenerator TriangleGenerator;
    public TriangleGenerator TriangleGenerator2;
    public Triangle2Generator Triangle2Generator;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * TriangleGenerator.currentSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        int random = Random.Range(1, 100);
        if(collision.gameObject.CompareTag("nextLine"))
        {
            if(random<=60)
            {
                TriangleGenerator.generateTriangleWithGap();
            }
            if(random>60 && random<=80)
            {
                TriangleGenerator.generateTriangleWithGap2();
            }
            if(random>80)
            {
                TriangleGenerator.generateTriangleWithGap();
            }
            
        }
        if(collision.gameObject.CompareTag("Finish"))
        {
            Destroy(this.gameObject);
        }
    }
}