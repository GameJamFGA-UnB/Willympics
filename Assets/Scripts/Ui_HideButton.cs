using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Ui_Button : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData) // Ao apertar botao
    {
        Ui.instance.steps--; // Diminui N de passos
        gameObject.SetActive(false); // Desativa o botao
    }
}
