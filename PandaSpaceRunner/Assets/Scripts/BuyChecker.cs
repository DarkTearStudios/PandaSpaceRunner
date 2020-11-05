using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyChecker : MonoBehaviour
{
    public GameObject[] BuyCheckButton;
    public GameObject[] DiamondsCost;
    public Toggle[] Toggle;
    public int BuyCheck;
    public int TotalDiamonds;


    private void Awake()
    {
        TotalDiamonds = PlayerPrefs.GetInt("totalDiamonds");
        BuyCheck = PlayerPrefs.GetInt("BuyCheck0");
    }
    

    public void Buy1()
    {
        if (TotalDiamonds >= 1000)
        {
            TotalDiamonds = TotalDiamonds - 1000;
            PlayerPrefs.SetInt("totalDiamonds", TotalDiamonds);
            BuyCheckButton[0].SetActive(false);
            Toggle[0].interactable = true;
            BuyCheck = 1;
            PlayerPrefs.SetInt("BuyCheck0", BuyCheck);
            DiamondsCost[0].SetActive(false);
            UiManager.instance.GemCheckClose();
            Toggle[0].isOn = true;
        }

        else
        {
            
            
            UiManager.instance.GemCheckClose();

            UiManager.instance.NotEnoughOpen();
        }
    }

    public void Buy2()
    {
        if (TotalDiamonds >= 1000)
        {
            TotalDiamonds = TotalDiamonds - 1000;
            PlayerPrefs.SetInt("totalDiamonds", TotalDiamonds);
            BuyCheckButton[1].SetActive(false);
            Toggle[1].interactable = true;
            BuyCheck = 1;
            PlayerPrefs.SetInt("BuyCheck1", BuyCheck);
            DiamondsCost[1].SetActive(false);
            UiManager.instance.GemCheckClose2();
            Toggle[1].isOn = true;
        }

        else
        {
            Debug.Log("Not Engough Gems");

            UiManager.instance.GemCheckClose2();

            UiManager.instance.NotEnoughOpen();

        }
    }

    public void Buy3()
    {
        if (TotalDiamonds >= 1000)
        {
            TotalDiamonds = TotalDiamonds - 1000;
            PlayerPrefs.SetInt("totalDiamonds", TotalDiamonds);
            BuyCheckButton[2].SetActive(false);
            Toggle[2].interactable = true;
            BuyCheck = 1;
            PlayerPrefs.SetInt("BuyCheck2", BuyCheck);
            DiamondsCost[2].SetActive(false);
            UiManager.instance.GemCheckClose3();
            Toggle[2].isOn = true;
        }

        else
        {
            Debug.Log("Not Engough Gems");

            UiManager.instance.GemCheckClose3();

            UiManager.instance.NotEnoughOpen();
        }
    }

    public void Buy4()
    {
        if (TotalDiamonds >= 1000)
        {
            TotalDiamonds = TotalDiamonds - 1000;
            PlayerPrefs.SetInt("totalDiamonds", TotalDiamonds);
            BuyCheckButton[3].SetActive(false);
            Toggle[3].interactable = true;
            BuyCheck = 1;
            PlayerPrefs.SetInt("BuyCheck3", BuyCheck);
            DiamondsCost[3].SetActive(false);
            UiManager.instance.GemCheckClose4();
            Toggle[3].isOn = true;
        }

        else
        {
            Debug.Log("Not Engough Gems");

            UiManager.instance.GemCheckClose4();

            UiManager.instance.NotEnoughOpen();
        }
    }

    public void Buy5()
    {
        if (TotalDiamonds >= 1000)
        {
            TotalDiamonds = TotalDiamonds - 1000;
            PlayerPrefs.SetInt("totalDiamonds", TotalDiamonds);
            BuyCheckButton[4].SetActive(false);
            Toggle[4].interactable = true;
            BuyCheck = 1;
            PlayerPrefs.SetInt("BuyCheck4", BuyCheck);
            DiamondsCost[4].SetActive(false);
            UiManager.instance.GemCheckClose5();
            Toggle[4].isOn = true;
        }

        else
        {
            Debug.Log("Not Engough Gems");

            UiManager.instance.GemCheckClose5();

            UiManager.instance.NotEnoughOpen();
        }
    }
}
