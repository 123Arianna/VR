using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fine : MonoBehaviour
{
    public string end;
    public int a;


    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            a = 4;
            SceneManager.LoadScene(end);

        }
    }
}
