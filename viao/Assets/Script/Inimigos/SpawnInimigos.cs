using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInimigos : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] inimigos;
    // Start is called before the first frame update
    void Start()
    {
        SpawnImigos();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnImigos()
    {
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            int inimigoSpawnado = Random.Range(0, inimigos.Length);
            Instantiate(inimigos[inimigoSpawnado], spawnPoints[i]);
        }
    }
}
