using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NivelCombustivel : MonoBehaviour
{
    public float nivelMaxCombustivel;
    public float nivelAtualCombustivel;
    public Slider barraCombustivel;
    // Start is called before the first frame update
    void Start()
    {
        nivelAtualCombustivel = nivelMaxCombustivel;
        barraCombustivel.maxValue = nivelMaxCombustivel;
        barraCombustivel.value = nivelAtualCombustivel;
    }

    // Update is called once per frame
    void Update()
    {
        GastoCombustivel();
    }
    void GastoCombustivel()
    {
        nivelAtualCombustivel -= Time.deltaTime;
        barraCombustivel.value = nivelAtualCombustivel;
        
    }
    public void Abastecimento(float reabastecimento)
    {
        /*if (nivelAtualCombustivel <= 30)
        {
            nivelAtualCombustivel += reabastecimento;
        }*/
        //nivelAtualCombustivel += reabastecimento;
        if ((nivelAtualCombustivel + reabastecimento) >= nivelMaxCombustivel)
        {
            nivelAtualCombustivel = nivelMaxCombustivel;
        }
        else
        {
            nivelAtualCombustivel += reabastecimento;
        }
    }
}
