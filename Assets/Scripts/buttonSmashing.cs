using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;


public class buttonSmashing : MonoBehaviour
{
    [SerializeField] private GameObject canvasPanel;
    [SerializeField] private TextMeshProUGUI relogio;
    [SerializeField] TextMeshProUGUI contagem;
    private valores valoresScript;

    private int i = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        valoresScript = FindFirstObjectByType<valores>();
    }
    // Update is called once per frame
    void Update()
    {
        if (canvasPanel.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.Space) && relogio.text != "00:00")
            {
                // Reduz o n�mero exibido em contagem em 1
                int currentCount = int.Parse(contagem.text);
                currentCount = Mathf.Max(0, currentCount - 1); // Evita valores negativos
                contagem.text = currentCount.ToString();
                if (currentCount == 0)
                {
                    //Debug.Log("opa");
                    SceneManager.LoadSceneAsync(3);
                    return;
                }
            }
            if (relogio.text == "00:00") {
                if (i == 0) {
                    i = 1;
                    valoresScript.var1 += 5;
                }
                SceneManager.LoadSceneAsync(2);
                return; }
        }
    }
}
