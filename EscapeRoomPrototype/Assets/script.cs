using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class tabel : MonoBehaviour
{
    
    public GameObject textBox;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("by Table");
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("Staying");
        textBox.active = true;
    }


    void OnTriggerExit(Collider other)
    {
        Debug.Log("Off Table");

        textBox.active = false;

    }
}
