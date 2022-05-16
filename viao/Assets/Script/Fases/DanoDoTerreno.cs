using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanoDoTerreno : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.gameObject.GetComponent<Imunidade>().estaImune == false)
            {
                collision.gameObject.GetComponent<Jogador>().PerdaDeVida(1);
                collision.gameObject.GetComponent<Imunidade>().estaImune = true;
                collision.gameObject.transform.position = new Vector3(0f, -2f, 0f);
            }
        }
        
    }
}
