using UnityEngine;

public class TriangleScript : MonoBehaviour
{
    public TriangleGenerator TriangleGenerator;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * TriangleGenerator.currentSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("nextLine"))
        {
            TriangleGenerator.generateTriangleWithGap();
        }
        if(collision.gameObject.CompareTag("Finish"))
        {
            Destroy(this.gameObject);
        }
    }
}