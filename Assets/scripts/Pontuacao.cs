using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Pontuacao : MonoBehaviour {

    [SerializeField]
    private Text textoPontuacao;
    private int pontos;
    private AudioSource somPontuacao;

    private void awake(){
        this.somPontuacao = this.GetComponent<AudioSource>();
    }

    public void AdicionarPontos()
    {
        this.pontos++;
        this.somPontuacao.Play();
        this.AtualizarTexto();
    }         

    private void AtualizarTexto()
    {
        this.textoPontuacao.text = this.pontos.ToString();
    }   

    public void Reiniciar()
    {
        this.pontos = 0;
        this.AtualizarTexto();
    }       
}
