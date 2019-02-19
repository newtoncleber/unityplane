﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{   
    [SerializeField]
    private float velocidade;
    [SerializeField]
    private float variacaoEixoY;
    private Vector3 posicaoDoAviao;
    private Pontuacao pontuacao;
    private bool pontuei;

    private void Awake(){
        this.transform.Translate(Vector3.up * Random.Range(-this.variacaoEixoY,this.variacaoEixoY) );
        this.pontuei = false;
    }

    private void Start()
    {
        this.posicaoDoAviao = GameObject.FindObjectOfType<Aviao>().transform.position;
        this.pontuacao = GameObject.FindObjectOfType<Pontuacao>();
    }

    private void Update(){
        this.transform.Translate(Vector3.left * this.velocidade * Time.deltaTime);

        if(!this.pontuei && this.transform.position.x < this.posicaoDoAviao.x)
        {
            this.pontuei = true;
            this.pontuacao.AdicionarPontos();
        }        
    } 

    private void OnTriggerEnter2D(Collider2D other)
    {
        this.Destruir();
    }

    public void Destruir(){
        GameObject.Destroy(this.gameObject);
    }
}
