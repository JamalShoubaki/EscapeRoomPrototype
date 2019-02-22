using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    [SerializeField] private Text uiText;
    [SerializeField] private float mainTimer;
    private float timer=0;
    private bool canCount = true;
    private bool doOnce = false;

    void StartTimer(){
        timer = mainTimer;
    }

    void Update()
    {
        if (timer < 100.00f && canCount)
        {
            timer += Time.deltaTime;
            uiText.text = timer.ToString(": ");
            uiText.text = timer.ToString("F");
        }

        else if ((timer >= 100.00f) && (!doOnce))
        {
            canCount = false;
            doOnce = true;
            uiText.text = "100.00";
            timer = 100.00f;
        }
    }

}
