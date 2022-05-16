using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cenario1 : MonoBehaviour
{
    public float velocidade;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 20); 
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 movimento = new Vector3(0f, -1f, 0f);
        //transform.position += movimento * velocidade * Time.deltaTime;
        //Foma resumida abaixo:
        Movimento();

    }
    void Movimento()
    {
        transform.position += new Vector3(0f, velocidade * Time.deltaTime, 0f);
    }
}
