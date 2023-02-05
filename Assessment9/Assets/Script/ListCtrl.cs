using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ListCtrl : MonoBehaviour
{
    [SerializeField] protected int numberElements;
    [SerializeField] protected List<string> Textbox;
    [SerializeField] protected TextMeshProUGUI index;
    [SerializeField] protected TextMeshProUGUI ButtanContent;
    [SerializeField] protected Transform LButton;
    [SerializeField] protected Transform List;
    private void Start()
    {
        for(int i = 0; i < numberElements; i++)
        {
            Spawn(i + 1);
        }    
    }
    void Spawn(int i)
    {
        index.text = i.ToString();
        ContentOnButtan();
        Transform newButton = Instantiate(LButton);
        newButton.SetParent(List, false);
        newButton.gameObject.SetActive(true);
    }
    void ContentOnButtan()
    {
        int rand = Random.Range(0, Textbox.Count);
        ButtanContent.text = Textbox[rand];
    }    
}
