using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigosMoveis : MonoBehaviour
{
    public float velocidade;
    public float direcao;
    public float tempoMudancaDirecao;
    public float mudarDirecao;
    // Start is called before the first frame update
    void Start()
    {
        mudarDirecao = tempoMudancaDirecao;
    }

    // Update is called once per frame
    void Update()
    {
        MovimentoLateral();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Projetil"))
        {
            GameManager.instance.PontuacaoInimigos(20);
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
    void MovimentoLateral()
    {
        mudarDirecao -= Time.deltaTime;
        transform.position += new Vector3(velocidade * direcao * Time.deltaTime, 0f, 0f);
        if (mudarDirecao <= 0)
        {
            direcao = direcao * -1;
            mudarDirecao = 2 * tempoMudancaDirecao;
        }
        if (direcao < 0)
        {
            transform.eulerAngles = new Vector3(0f, 0f, 90f);
        }
        else if (direcao >0)
        {
            transform.eulerAngles = new Vector3(0f, 0f, -90f);
        }
    }
}
