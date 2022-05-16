using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjetilJogador : MonoBehaviour
{
    public float velocidadeProjetil;
    private void Start()
    {
        Destroy(this.gameObject, 2);        
    }

    private void Update()
    {
        MovimentoProjetil();
    }

    private void MovimentoProjetil()
    {
        transform.Translate(Vector3.up * velocidadeProjetil * Time.deltaTime);
    }
}
