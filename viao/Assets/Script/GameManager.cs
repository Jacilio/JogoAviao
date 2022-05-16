using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject painelGameOver;
    public Text textoPontuacaoFinal;
    public Text textoInimigosMortos;
    public Text textoVidas;
    public Text textoPontuacaoTotal;
    public static GameManager instance;
    public float pontuacao;
    public int pontuacaoInimigo;
    public int pontuacaoTotal;
    public int inimigosMortos;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        PontuacaoTempo();
        PontuacaoNaTela();
    }
    void PontuacaoTempo()
    {
        pontuacao += Time.deltaTime;
    }
    public void PontuacaoInimigos(int pontosGanhos)
    {
        pontuacaoInimigo += pontosGanhos;
        inimigosMortos++;
    }
    void PontuacaoNaTela()
    {
        textoPontuacaoTotal.text = "PONTUACAO: " + pontuacaoTotal;
        pontuacaoTotal = (int)pontuacao + pontuacaoInimigo;
    }
    public void VidaNaTela(int vidaPerdida)
    {
        textoVidas.text = "x " + vidaPerdida;
    }
    void PontuacaoFinal()
    {
        textoInimigosMortos.text = "Inimigos Mortos: " + inimigosMortos;
        textoPontuacaoFinal.text = "Pontuação Final: " + pontuacaoTotal;
    }
    public void GameOver()
    {
        Time.timeScale = 0f;
        painelGameOver.SetActive(true);
        PontuacaoFinal();
    }
}
