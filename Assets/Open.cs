using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open : MonoBehaviour
{
    public GameObject[] key; //la chiave per aprire il cancelli  
    public GameObject LeftGate; //il cancello da aprire  
    public GameObject RightGate; //il cancello da aprire  
    private Animator left;
    private Animator right;
    
    // Start is called before the first frame update
    void Start()
    {
        right = RightGate.GetComponent<Animator>();
        left =  LeftGate.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Key(key))
        {
            left.SetBool("apri", true);
            right.SetBool("apri", true);
        }
    
    }

    //Controlla che si abbiano tutte le chiavi
    public bool Key(GameObject[] keys)
    {
        for (int i = 0; i < keys.Length; i++)
        {
            if (!keys[i].activeSelf)
            {
                return false;
            }
        }
        return true;
    }
}
