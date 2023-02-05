using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PrintContent : MonoBehaviour
{
    [SerializeField] protected TextMeshProUGUI index;
    [SerializeField] protected TextMeshProUGUI ButtanContent;

    public void ContentPrint()
    {
        int numberofContent = int.Parse(index.text);
        if(numberofContent % 3 == 0)
        {
            Debug.Log(ButtanContent.text); 
        }    
        else
        {
            Debug.Log(index.text);
        }   
    }    
}
