using UnityEngine;

public class TriangleGenerator : MonoBehaviour
{
    public GameObject Triangle;
    public float MinSpeed;
    public float MaxSpeed;
    public float currentSpeed;
    public float speedMulti;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Awake()
    {
        currentSpeed = MinSpeed;
        generateTriangle();
    }

    // Update is called once per frame
    public void generateTriangle()
    {
        GameObject TriangleIns = Instantiate(Triangle, transform.position, transform.rotation);
        TriangleIns.GetComponent<TriangleScript>().TriangleGenerator = this;
    }

    public void generateTriangleWithGap()
    {
        float randomWait = Random.Range(0.1f, 1.2f);
        Invoke("generateTriangle", randomWait);
    }

    void Update()
    {
        if(currentSpeed<MaxSpeed)
        {
            currentSpeed += speedMulti;
        }
    }
}