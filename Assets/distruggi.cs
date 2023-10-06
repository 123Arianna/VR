using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distruggi : MonoBehaviour
{
    public GameObject muori;
    public GameObject esplosione;
    public string tag;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == tag)
        {
            Destroy(collision.gameObject, 0.05f);
            muori.SetActive(false);
            esplosione.SetActive(false);
        }
    }
}
