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

    /// <summary>
    /// Sent when another object enters a trigger collider attached to this
    /// object (2D physics only).
    /// </summary>
    /// <param name="other">The other Collider2D involved in this collision.</param>
    private void OnTriggerEnter2D(Collider2D other)
    {
        this.Destruir();
    }

    private void Destruir(){
        GameObject.Destroy(this.gameObject);
    }
}
