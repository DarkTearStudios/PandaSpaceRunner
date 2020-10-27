using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelect : MonoBehaviour
{

    public bool[] Characterbool;
    public bool[] Camera1bool;
    public bool[] Backgroundbool;

    public GameObject[] Character;
    public GameObject[] Camera1;
    public GameObject[] Background;
    public GameObject[] Selector;
    



    // Start is called before the first frame update
    void Start()
    {
        Selector[0].GetComponent<Toggle>().isOn = true;

        Selector[0].GetComponent<Toggle>().interactable = true;
        Selector[1].GetComponent<Toggle>().interactable = false;
        Selector[2].GetComponent<Toggle>().interactable = false;
        Selector[3].GetComponent<Toggle>().interactable = false;
        Selector[4].GetComponent<Toggle>().interactable = false;
        Selector[5].GetComponent<Toggle>().interactable = false;
    }

    // Update is called once per frame
    void Update()
    {

       

    }

    void CharcterSelect()
    {
        
    }
}
