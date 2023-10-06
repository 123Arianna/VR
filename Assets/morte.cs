using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class morte : MonoBehaviour
{
    public Animator animator;


    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            animator.SetBool("muori", true);

        }
    }

}
