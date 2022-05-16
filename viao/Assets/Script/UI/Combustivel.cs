using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combustivel : MonoBehaviour
{
    public float cargaCombustivel;

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
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<NivelCombustivel>().Abastecimento(cargaCombustivel);
            Destroy(this.gameObject);
        }
        if (collision.gameObject.CompareTag("Projetil"))
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
    }
}
