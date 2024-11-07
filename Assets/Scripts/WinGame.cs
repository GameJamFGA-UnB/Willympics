using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour
{   
    private valores valoresScript;
    public void RestartGame()
    {   
        valoresScript = FindFirstObjectByType<valores>();
        valoresScript.var1 = 0; // Reseta a dificuldade quando vitoria
        valoresScript.var2 = 0;
        valoresScript.var3 = 0;
        SceneManager.LoadSceneAsync(0);
        return;
    }
}
