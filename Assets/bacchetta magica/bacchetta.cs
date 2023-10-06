using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bacchetta : MonoBehaviour
{
    public bool lanciaIncantesimo;
    public Collider colliderBacchetta;
    public GameObject cerchio;
    public bool toccato;
    public bool toccatobos;

    // Start is called before the first frame update
    void Start()
    {
        lanciaIncantesimo = false;
        toccato = false;
        toccatobos=false;
    }

    // Update is called once per frame
    void Update()
    {
        void OnTriggerEnter(Collider c)
        {
            toccato = true;
            if (c.gameObject.tag == "cerchi")
            {
                toccato = true;
                c.gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, c.gameObject.transform.position.z);
            }

        } 

        if (lanciaIncantesimo==true) //se ha premuto il bottone e la bacchetta sta toccando un cerchio
        {
            toccatobos = true;
           
           /* void OnCollisionEnter(Collision c)
            {
                toccato = true;
                if (c.gameObject.tag == "cerchi")
                {
                    toccato = true;
                    c.gameObject.transform.position=new Vector3(transform.position.x,transform.position.y,c.gameObject.transform.position.z);
                }

            }*/

       }
   }

    public void lancia()
    {
        lanciaIncantesimo = true;
    } 
    
    public void disattiva()
    {
        lanciaIncantesimo = false;
    }

    
}




   


   
