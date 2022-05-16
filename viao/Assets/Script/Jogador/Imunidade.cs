using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Imunidade : MonoBehaviour
{
    public bool estaImune;
    public float tempoImunidade;
    public float tempoAtualImunidade;
    // Start is called before the first frame update
    void Start()
    {
        estaImune = false;
    }

    // Update is called once per frame
    void Update()
    {
        SistemaImune();
    }
    void SistemaImune()
    {
        if (estaImune == true)
        {
            tempoAtualImunidade -= Time.deltaTime;
            if (tempoAtualImunidade <= 0)
            {
                estaImune = false;
                tempoAtualImunidade = tempoImunidade;
            }
        }
        
    }
}
