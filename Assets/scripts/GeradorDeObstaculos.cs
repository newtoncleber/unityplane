using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObstaculos : MonoBehaviour
{
    [SerializeField]
    private GameObject ManualDeInstrucoes;

    [SerializeField]
    private float TempoParaGerar;
    private float cronometro;
    // Start is called before the first frame update
    private void Awake()
    {
        this.cronometro = this.TempoParaGerar;
    }

    // Update is called once per frame
    private void Update()
    {
        this.cronometro -= Time.deltaTime;
        if(this.cronometro < 0)
        {
            GameObject.Instantiate(this.ManualDeInstrucoes, this.transform.position, Quaternion.identity);
            this.cronometro = this.TempoParaGerar;
        }
    }
}
