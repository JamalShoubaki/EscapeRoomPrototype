using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tabelScript : MonoBehaviour
{
    
  
    public GameObject textbox;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("On table");
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("Staying");
        textbox.active = true;
    }


    void OnTriggerExit(Collider other)
    {
        Debug.Log("Off table");
        textbox.active = false;

    }


}
