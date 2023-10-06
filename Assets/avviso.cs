using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avviso : MonoBehaviour
{

    public GameObject canvas;
    public int a;

      void OnCollisionEnter(Collision collision)
    {
        
        if (a!=1 && collision.gameObject.tag == "Player")
        {
            canvas.SetActive(true);
            a = 1;

        }
    }

 
}
