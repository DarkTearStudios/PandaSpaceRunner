using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyCheck1 : MonoBehaviour
{
    public GameObject BuyCheckButton;
    public GameObject DiamondsCost;
    public Toggle Toggle;
    public int BuyCheck;
    public int TotalDiamonds;


    private void Awake()
    {
        TotalDiamonds = PlayerPrefs.GetInt("totalDiamonds");
        BuyCheck = PlayerPrefs.GetInt("BuyCheck0");
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Buy()
    {
        if (TotalDiamonds > 1000)
        {
            TotalDiamonds = TotalDiamonds - 1000;
            PlayerPrefs.SetInt("totalDiamonds", TotalDiamonds);
            BuyCheckButton.SetActive(false);
            Toggle.interactable = true;
            BuyCheck = 1;
            PlayerPrefs.SetInt("BuyCheck0", BuyCheck);
            DiamondsCost.SetActive(false);
            UiManager.instance.GemCheckClose();
            Toggle.isOn = true;
        }

        else
        {
            Debug.Log("Not Engough Gems");
            
            UiManager.instance.GemCheckClose();

            UiManager.instance.NotEnoughOpen();
        }
    }
}
