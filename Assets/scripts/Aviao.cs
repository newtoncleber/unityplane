using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour
{
    private Rigidbody2D fisica;
    [SerializeField]
    private float forca = 10;
    private Diretor diretor;
    private Vector3 posicaoInicial;
    
    private void Awake()
    {
        this.fisica = this.GetComponent<Rigidbody2D>();
        this.posicaoInicial = this.transform.position;
    }

 

    private void Start()
    {
        this.diretor = GameObject.FindObjectOfType<Diretor>();
    }   

    private void Update()
    {
        if (Input.GetButtonDown("Fire1")){
            this.Impulsionar();
        }
    }

    private void Impulsionar(){
        this.fisica.velocity = Vector2.zero;
        this.fisica.AddForce(Vector2.up * this.forca, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D outro)
    {
        this.diretor.FinalizarJogo();
        this.fisica.simulated = false;
    }    

    public void Reiniciar(){
        this.transform.position = this.posicaoInicial;
        this.fisica.simulated = true;
    }
}
