using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigosParados : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Projetil"))
        {
            GameManager.instance.PontuacaoInimigos(10);
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            collision.gameObject.GetComponent<Jogador>().PerdaDeVida(1);
            Debug.Log("Perdeu Vida");
        }
    }

}
