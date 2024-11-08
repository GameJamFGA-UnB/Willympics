using UnityEngine;

public class Triangle2Generator : MonoBehaviour
{
    public GameObject Triangle2;
    public float MinSpeed;
    public float MaxSpeed;
    public float currentSpeed;
    public float speedMulti;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Awake()
    {
        currentSpeed = MinSpeed;
    }

    // Update is called once per frame
    public void generateTriangle2()
    {
        GameObject TriangleIns = Instantiate(Triangle2, transform.position, transform.rotation);
        TriangleIns.GetComponent<Triangle2Script>().Triangle2Generator = this;
        TriangleIns.GetComponent<TriangleScript>().Triangle2Generator = this;
    }

    public void generateTriangleWithGap2()
    {
        float randomWait = Random.Range(0.1f, 1.2f);
        Invoke("generateTriangle2", randomWait);
    }

    void Update()
    {
        if(currentSpeed<MaxSpeed)
        {
            currentSpeed += speedMulti;
        }
    }
}
