using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class incantesimo : MonoBehaviour
{

    public GameObject BlueMagic;
    public GameObject GreenMagic;
    public GameObject OrangeMagic;
    private float speed=7;
    public Transform puntoLancio;
    public InputActionProperty isPressedBlue;
    public InputActionProperty isPressedGreen;
    public GameObject fuoco;
    public GameObject alberi;
    public bool GreenAllowed;
    public bool OrangeAllowed;

    //lancia l'incantesimo blu
    public void lanciaIncantesimoBlu()
     {
         GameObject magic = Instantiate(BlueMagic, puntoLancio.position, puntoLancio.rotation);
        //muovi l'incantesimo (gameObject.farward muove l'oggetto l'ungo l'asse Z) 
        magic.GetComponent<Rigidbody>().velocity = puntoLancio.forward * speed; 

     }

    //lancia l'incantesimo verde
    public void lanciaIncantesimoVerde()
     {
         GameObject magic = Instantiate(GreenMagic, puntoLancio.position, puntoLancio.rotation);
         magic.GetComponent<Rigidbody>().velocity = puntoLancio.forward * speed; //muovi l'incantesimo

     }

    //lancia l'incantesimo verde
    public void lanciaIncantesimoArancione()
    {
        GameObject magic = Instantiate(OrangeMagic, puntoLancio.position, puntoLancio.rotation);
        magic.GetComponent<Rigidbody>().velocity = puntoLancio.forward * speed; //muovi l'incantesimo

    }


    void Update()
   {
        // Può fare l'incantesimo verde solo se ha risolto l'indovinello dei fuochi
        GreenAllowed = fuoco.GetComponent<fire>().resolved;
        // Può fare l'incantesimo verde solo se ha risolto l'indovinello degli alberi
        OrangeAllowed = alberi.GetComponent<accendiAlberi>().resolved; 
        
        float pressedBlue = isPressedBlue.action.ReadValue<float>();
        float pressedGreen = isPressedGreen.action.ReadValue<float>();

        
        if (pressedBlue > 0.8)
        {
            lanciaIncantesimoBlu();
        }

        if (GreenAllowed && !OrangeAllowed && pressedGreen > 0.8)
        {
            lanciaIncantesimoVerde();
        } 
        if (OrangeAllowed && pressedGreen > 0.8)
        {
            lanciaIncantesimoArancione();
        }
   }

}
