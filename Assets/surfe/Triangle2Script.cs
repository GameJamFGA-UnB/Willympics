using UnityEngine;

public class Triangle2Script : MonoBehaviour
{
    public Triangle2Generator Triangle2Generator;
    public TriangleGenerator TriangleGenerator;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Triangle2Generator.currentSpeed * Time.deltaTime);
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
                Triangle2Generator.generateTriangleWithGap2();
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
