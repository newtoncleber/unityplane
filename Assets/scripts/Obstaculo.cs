using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{   
    [SerializeField]
    private float velocidade;
    [SerializeField]
    private float variacaoEixoY;

    private void Awake(){
        this.transform.Translate(Vector3.up * Random.Range(-this.variacaoEixoY,this.variacaoEixoY) );
    }

    private void Update(){
        this.transform.Translate(Vector3.left * this.velocidade * Time.deltaTime);
    } 
}
