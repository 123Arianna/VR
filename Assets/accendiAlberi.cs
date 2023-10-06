using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class accendiAlberi : MonoBehaviour
{

    public GameObject[] cerchi;
    public GameObject[] alberi;
    public bool resolved;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (sonoTuttiAttivi(cerchi))//Se tutti i cerchi sono attivati
        {
            for (int i = 0; i < 5; i++) //accendi tutti gli alberi
            {
                alberi[i].SetActive(true);
                resolved = true;
            }
        }
        
    }

    //Controlla se sono stati attivati tutti i cerchi
    bool sonoTuttiAttivi(GameObject[] tutti)
    {
        for(int i = 0; i < tutti.Length; i++)
        {
            if (!tutti[i].activeSelf)
                return false;
        }
        return true;
    }
}
