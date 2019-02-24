using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompareScript
{
    public void Text_Changed (string newText){
    string escape = "Escape";
        if(newText == escape){
            Debug.Log("Same");
        }
        else
            Debug.Log("Not the same!");

    
    }


}