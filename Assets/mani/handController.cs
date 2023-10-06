using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(ActionBasedController))]

public class handController : MonoBehaviour
    { 

    ActionBasedController controller;
  
    public bool chiudi;
    private float pressed;
    
    public Animator animator;
    public GameObject hand;
    
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<ActionBasedController>();
        animator = hand.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        pressed = controller.selectAction.action.ReadValue<float>();

        if (pressed!=0)
        {
            animator.SetBool("chiudi", true);
        }
        else
        {
            animator.SetBool("chiudi", false);
        }        
    }
}
