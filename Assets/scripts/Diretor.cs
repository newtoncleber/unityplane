using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour
{
    [SerializeField]
    private GameObject ImagemGameOver;
    private Aviao aviao;
    private Pontuacao pontuacao;

    private void Start()
    {
        this.aviao = GameObject.FindObjectOfType<Aviao>();
        this.pontuacao = GameObject.FindObjectOfType<Pontuacao>();
    }  
    public void FinalizarJogo()
    {
        this.ImagemGameOver.SetActive(true);
        Time.timeScale = 0;
    }

    public void ReiniciarJogo(){
        this.ImagemGameOver.SetActive(false);
        this.aviao.Reiniciar();
        this.pontuacao.Reiniciar();
        this.DestruirObstaculos();
        Time.timeScale = 1;        
    }

    private void DestruirObstaculos(){
        Obstaculo[] obstaculos = GameObject.FindObjectsOfType<Obstaculo>();
        foreach(Obstaculo obstaculo in obstaculos)
        {
            obstaculo.Destruir();
        }        
    }
}
