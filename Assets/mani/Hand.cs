using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{

    Animator animator;
    private float prendiAttuale;
    private float prendiTarget;
    //public velocita;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        move(); 
    }

    void setPrendi(float v)
    {
        prendiTarget = v;
    }

    private void move()
    {
        if (prendiAttuale!=prendiTarget) 
        {
            //prendiAttuale = Mathf.MoveTowards(prendiAttuale, prendiTarget, Time.deltaTime * velocita);
            
        }
    }
}
