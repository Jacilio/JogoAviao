using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FasesProcedurais : MonoBehaviour
{
    public GameObject[] fases;
    public Transform pontoDeSpawn;

    public float tempoSpawnMaximo;
    public float tempoSpawnAtual;

    // Start is called before the first frame update
    void Start()
    {
        tempoSpawnAtual = tempoSpawnMaximo;
        SpawnFase();
    }

    // Update is called once per frame
    void Update()
    {
        tempoSpawnAtual -= Time.deltaTime;
        if (tempoSpawnAtual <= 0)
        {
            SpawnFase();
        }
    }
    void SpawnFase()
    {
        int faseAleatoria = Random.Range(0, fases.Length);
        Instantiate(fases[faseAleatoria], pontoDeSpawn.position, pontoDeSpawn.rotation);
        tempoSpawnAtual = tempoSpawnMaximo;
        Debug.Log(fases.Length);
        Debug.Log(faseAleatoria);
    }
}
