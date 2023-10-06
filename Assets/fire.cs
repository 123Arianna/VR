using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{

    public GameObject OrangeFire;
    public GameObject BlueFire;
    public GameObject YellowFire;
    public GameObject GreenFire;
    public GameObject Fuoco;
    public bool resolved;
    public bool Blue;
    public bool Yellow;
    public string tag;
    public string fiore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fiore = Fuoco.GetComponent<FlowerInFire>().tag; //il tag del fiore che ha toccato il fuoco
        if (fiore != null)
        {
            if (fiore=="BlueFlower") // se un fiore blu tocca il fuoco, aggirna "Blue"
            {
                Blue = true;
            }
            if (fiore == "YellowFlower")  // se un fiore giallo tocca il fuoco, aggirna "Yellow"
            {
                Yellow = true;
            } 
        }
        if(!resolved && (Blue && Yellow)) // Se ci sono entrambi i fiori accendi il fuoco verde
        {
            resolved = true;
            GreenFire.SetActive(true);
            OrangeFire.SetActive(false); 
            BlueFire.SetActive(false); 
            YellowFire.SetActive(false); 

        }
        if(!resolved && (!Blue && Yellow)) // Se c'è solo il fiore giallo accendi il fuoco giallo
        {
            GreenFire.SetActive(false);
            OrangeFire.SetActive(false);
            BlueFire.SetActive(false);
            YellowFire.SetActive(true);
        }
        if(!resolved && (Blue && !Yellow)) // Se c'è solo il fiore blu accendi il fuoco blu
        {
            GreenFire.SetActive(false);
            OrangeFire.SetActive(false);
            BlueFire.SetActive(true);
            YellowFire.SetActive(false);
        }
    }
    
}
