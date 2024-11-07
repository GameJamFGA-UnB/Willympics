using UnityEngine;
using TMPro;

public class timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timertext;
    [SerializeField] public float remaining_time;
    private valores valoresScript;
    public bool parajogo = false;
    private int a;
    // Update is called once per frame

    void Start()
    {
        // Encontra o script valores na cena
        valoresScript = FindObjectOfType<valores>();
        a = valoresScript.var1;
        remaining_time += a;
    }
        void FixedUpdate()
    {
        if (timertext == null || !timertext.gameObject.activeInHierarchy)
        {
            return; // Sai do método Update se o timertext estiver desativado
        }
        if (remaining_time > 0)
        {
            remaining_time -= Time.deltaTime;
        }
        else if (remaining_time < 0) { remaining_time = 0; timertext.color = Color.red; parajogo = true; }
        int minutes = Mathf.FloorToInt(remaining_time / 60);
        int seconds = Mathf.FloorToInt(remaining_time % 60);
        timertext.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
