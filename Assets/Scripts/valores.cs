using UnityEngine;

public class valores : MonoBehaviour
{
    public int var1 = 0;

    public int var2 = 0;

    public int var3 = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
