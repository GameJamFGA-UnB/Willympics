using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class chamateste : MonoBehaviour
{
    [SerializeField] private GameObject player; // Arraste o jogador no Inspector
    [SerializeField] private GameObject canvasPanel; // Arraste o painel do Canvas aqui
    [SerializeField] private GameObject secondcanvasPanel;

    private PlayerController playerController;
    private bool runned = false;

    void Start()
    {
        if (player != null)
        {
            // Obtém o componente PlayerController do jogador
            playerController = player.GetComponent<PlayerController>();
        }
    }

    void Update()
    {
        bool podeAndarStatus = playerController.podeandar;
        if (playerController != null && !runned && !podeAndarStatus)
        {
            // Verifica o valor de podeandar e inicia a coroutine com delay
            StartCoroutine(ToggleCanvasWithDelay());
            runned = true;
        }
        StopCoroutine(ToggleCanvasWithDelay());
    }

    private IEnumerator ToggleCanvasWithDelay()
    {
        
        canvasPanel.SetActive(!canvasPanel.activeSelf);
        // Aguarda 3 segundos antes de permitir outra atualização
        yield return new WaitForSeconds(3f);
        canvasPanel.SetActive(!canvasPanel.activeSelf);
        secondcanvasPanel.SetActive(!secondcanvasPanel.activeSelf);
        //Debug.Log(secondcanvasPanel.activeSelf);
        yield return null;
    }
}
