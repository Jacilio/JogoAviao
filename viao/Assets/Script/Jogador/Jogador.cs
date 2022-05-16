using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    public float velocidade;
    public GameObject projetilJogador;
    public Transform canhaoUnico;
    public int vidaDoJogador;
    public int vidaMaxJogador;
    public float cadenciaTiro;
    public float cadenciaAtualTiro;
    private void Start()
    {
        vidaDoJogador = vidaMaxJogador;
        cadenciaAtualTiro = cadenciaTiro;
    }

    void Update()
    {
        MovimentoJogador();
        TiroProjetil();
    }
    private void MovimentoJogador()
    {
        //comando de movimento lateral
        Vector3 movimento = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movimento * velocidade * Time.deltaTime;
    }
    private void TiroProjetil()
    {
        cadenciaAtualTiro -= Time.deltaTime;
        if (Input.GetKey("space") & cadenciaAtualTiro <= 0)
        {
            cadenciaAtualTiro = cadenciaTiro;
            Instantiate(projetilJogador, canhaoUnico.position, canhaoUnico.rotation);
        }
    }
    public void PerdaDeVida(int danoRecebido)
    {
        vidaDoJogador -= danoRecebido;
        GameManager.instance.VidaNaTela(vidaDoJogador);
        if (vidaDoJogador <= 0)
        {
            GameManager.instance.GameOver();
        }
    }
}
