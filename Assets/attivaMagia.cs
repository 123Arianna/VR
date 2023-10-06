using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attivaMagia : MonoBehaviour
{

    public GameObject magia;
    public string tag;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == tag)
        {
            Destroy(collision.gameObject, 0.05f);
            magia.SetActive(true);
        }
    }
 
}
