using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerInFire : MonoBehaviour
{

    public string tagFioreGiallo;
    public string tagFioreBlu;
    public string tag; 
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == tagFioreBlu || collision.gameObject.tag == tagFioreGiallo) //se il fuoco entra in contatto con un fiore, registra il tag del fiore
        {
            tag = collision.gameObject.tag;
            Destroy(collision.gameObject);
        }
    }


}
