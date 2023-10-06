using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attacco : MonoBehaviour
{

    public GameObject proiettile;
    public Transform partenza;
    public float speed=0.02f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        GameObject pallottola = Instantiate(proiettile, partenza.position, partenza.rotation);
        pallottola.GetComponent<Rigidbody>().velocity = partenza.forward * speed;
        Destroy(pallottola, 4);
        //yield return new WaitForSeconds(3);
        //StartCoroutine(Coroutine());

    }

    IEnumerator Coroutine()
    {
        

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(13);
        Debug.Log("ariiii ");



    }
}
