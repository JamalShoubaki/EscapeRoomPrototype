using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CandleTrigger : MonoBehaviour
{
    public GameObject CandleFloor;
    public GameObject HandCandle;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("On Candle");
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("Staying");
        CandleFloor.active = false;
        HandCandle.active = true;
    }


    void OnTriggerExit(Collider other){
        Debug.Log("Off Candle");
        
    }
}
