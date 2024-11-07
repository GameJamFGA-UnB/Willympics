using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ui : MonoBehaviour
{
    public static Ui instance;

    public int steps; // N de passos/apertos de botao necessarios para vencer
    public Ui_Button[] buttons; // Guarda cada botao

    private void Awake() // Inicializa uma instancia de Ui
    {
        instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        buttons = GetComponentsInChildren<Ui_Button>(true); // Pega todos os botoes existentes e coloca em um vetor
        OpenButtonUi(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T)) // Apertar T faz o botoes surgirem - DEBUG
            OpenButtonUi(); 
    }

    public void OpenButtonUi()
    {
        foreach (Ui_Button button in buttons) 
        {
            button.gameObject.SetActive(true); // Incializa o botao
            float randX = Random.Range(200, 1700);
            float randY = Random.Range(500, 800);

            button.transform.position = new Vector2(randX, randY); // Transporta para uma posicao aleatoria
        }
        steps = buttons.Length; // N de botoes = N de passos necessarios
    }
}
