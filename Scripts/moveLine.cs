using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using JetBrains.Annotations;
using UnityEngine;

public class moveLine : MonoBehaviour
{
    public static moveLine instance;
    private ProjectileLauncher script;
    
    public Transform plataforma;
    public Transform pontoInicio;
    public Transform pontoFim;
    public float velocidade = 1.5f;
    public bool estaMovendo=true;

    Vector2 P1;
    Vector2 P2;
    public Vector2 centro=new Vector2(2.5f, 0.0f);

    int direcao=1;

    void Awake(){
        if (instance == null)
        {
            instance = this;
            P1 = pontoInicio.position;
            P2 = pontoFim.position;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        //float x1=P1.x;
        //float x2=P2.x;

        //float a=Math.Abs(x1);
        //float b=Math.Abs(x2);

        //float n=(a+b)/2;
        
        GameObject obj = new GameObject("ProjectileLauncher");
        script = obj.AddComponent<ProjectileLauncher>();
    }
    private void Update(){
        Vector2 alvo = alvoAtual();
        if(estaMovendo){
        plataforma.position = Vector2.Lerp(plataforma.position, alvo, velocidade * Time.deltaTime);

        float distancia = (alvo - (Vector2)plataforma.position).magnitude;

        if(distancia<=0.1f){
            direcao*=-1;
        }
        }

        mouseClique();
    }

    public void mouseClique(){
        if(Input.GetMouseButton(0)){
            estaMovendo=false;

            Vector2 resultado = plataforma.position;

        int n;
        if(resultado.x>(centro.x-0.25f) && resultado.x<(centro.x+0.25f)){
            n=2;
        }else{
            n=1;
        }

        mandarValor(n);
        }
    }

    Vector2 alvoAtual(){
        if(direcao==1){
            return pontoInicio.position;
        }else{
            return pontoFim.position;
        }
    }

    private void OnDrawnGizmos(){
        if(plataforma!=null && pontoInicio!=null && pontoFim!=null){
            Gizmos.DrawLine(plataforma.transform.position, pontoInicio.position);
            Gizmos.DrawLine(plataforma.transform.position, pontoFim.position);
        }
    }

    public void mandarValor(int n){
        script.receberDado(n);
    }
}
