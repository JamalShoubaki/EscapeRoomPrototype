using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputReader : MonoBehaviour
{
    public void Text_Changed(string newText)
    {
        string escape = "Escape";
        if (newText == escape)
        {
            Debug.Log("Same");
        }
        else
            Debug.Log("Not the same!");


    }

}
