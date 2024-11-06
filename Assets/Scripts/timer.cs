using UnityEngine;
using TMPro;

public class timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timertext;
    [SerializeField] public float remaing_time;

    // Update is called once per frame
    void Update()
    {
        if (timertext == null || !timertext.gameObject.activeInHierarchy)
        {
            return; // Sai do método Update se o timertext estiver desativado
        }
        if (remaing_time > 0)
        {
            remaing_time -= Time.deltaTime;
        }
        else if (remaing_time < 0) { remaing_time = 0; timertext.color = Color.red; }
        int minutes = Mathf.FloorToInt(remaing_time / 60);
        int seconds = Mathf.FloorToInt(remaing_time % 60);
        timertext.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
