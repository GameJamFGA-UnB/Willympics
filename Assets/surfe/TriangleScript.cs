using UnityEngine;
using UnityEngine.SceneManagement;

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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        int random = Random.Range(1, 100);
        if(collision.gameObject.CompareTag("nextLine"))
        {
            if(random<=60)
            {
                //Debug.Log("1");
                TriangleGenerator.generateTriangleWithGap();
            }
            else if(random>60 && random<=80)
            {
                //Debug.Log("2");
                TriangleGenerator.generateTriangleWithGap2();
            }
            else if(random>80)
            {
                //Debug.Log("3");
                TriangleGenerator.generateTriangleWithGap();
            }
            
        }
        if(collision.gameObject.CompareTag("Finish"))
        {
            Destroy(this.gameObject);
        }
        else if(collision.gameObject.CompareTag("Player"))
            SceneManager.LoadSceneAsync(2);

    }
}