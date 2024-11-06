using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class buttonSmashing : MonoBehaviour
{
    [SerializeField] private GameObject canvasPanel;
    [SerializeField] private TextMeshProUGUI relogio;
    [SerializeField] TextMeshProUGUI contagem;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
}
    // Update is called once per frame
    void Update()
    {
        if (canvasPanel.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.Space) && relogio.text != "00:00")
            {
                Debug.Log(relogio.text);
                // Reduz o número exibido em contagem em 1
                int currentCount = int.Parse(contagem.text);
                currentCount = Mathf.Max(0, currentCount - 1); // Evita valores negativos
                contagem.text = currentCount.ToString();
            }
            if (relogio.text == "00:00") return;
        }
    }
}
