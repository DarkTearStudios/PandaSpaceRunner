using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EasterEgg : MonoBehaviour
{
    public int buttonint1;
    public int buttonint2;
    public int buttonint3;
    public int buttonint4;
    public int isBought;
    public int totalDiamonds;
    public GameObject BuyCheckPanel;
    public GameObject NotEnoughGemsPanel;
    

    // Start is called before the first frame update
    void Start()
    {
        buttonint1 = 0;
        buttonint2 = 0;
        buttonint3 = 0;
        buttonint4 = 0;
        totalDiamonds = PlayerPrefs.GetInt("totalDiamonds");
        isBought = PlayerPrefs.GetInt("isBought");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Button1()
    {
        buttonint1 = 1;
        PlayerPrefs.SetInt("Button1", buttonint1);
    }

    public void Button2()
    {
        if (buttonint1 == 1)
        {
            buttonint2 = 1;
            PlayerPrefs.SetInt("Button2", buttonint2);
        }

        else
        {
            buttonint1 = 0;
            buttonint2 = 0;
            buttonint3 = 0;
            buttonint4 = 0;

            PlayerPrefs.SetInt("Button1", buttonint1);
            PlayerPrefs.SetInt("Button2", buttonint2);
            PlayerPrefs.SetInt("Button3", buttonint3);
            PlayerPrefs.SetInt("Button4", buttonint4);
        }
    }

    public void Button3()
    {
        if (buttonint2 == 1 && buttonint2 == 1)
        {
            buttonint3 = 1;
            PlayerPrefs.SetInt("Button3", buttonint3);
        }

        else
        {
            buttonint1 = 0;
            buttonint2 = 0;
            buttonint3 = 0;
            buttonint4 = 0;

            PlayerPrefs.SetInt("Button1", buttonint1);
            PlayerPrefs.SetInt("Button2", buttonint2);
            PlayerPrefs.SetInt("Button3", buttonint3);
            PlayerPrefs.SetInt("Button4", buttonint4);

        }
    }

    public void Button4()
    {
        if (buttonint1 == 1 && buttonint2 == 1 && buttonint3 == 1)
        {
            buttonint4 = 2;
            PlayerPrefs.SetInt("Button4", buttonint4);
        }

        else
        {
            buttonint1 = 0;
            buttonint2 = 0;
            buttonint3 = 0;
            buttonint4 = 0;

            PlayerPrefs.SetInt("Button1", buttonint1);
            PlayerPrefs.SetInt("Button2", buttonint2);
            PlayerPrefs.SetInt("Button3", buttonint3);
            PlayerPrefs.SetInt("Button4", buttonint4);

        }


    }

    public void OpenEasterEggCheck()
    {
        if (buttonint4 == 2)
        {
            if (isBought == 1)
            {
                SceneManager.LoadScene(4);
            }

            else
            {
                BuyCheckPanel.SetActive(true);
            }
            
        }

        
    }

   

    public void GemCheck()
    {
        if (totalDiamonds >= 1000)
        {
            SceneManager.LoadScene(4);
            totalDiamonds -= 1000;
            PlayerPrefs.SetInt("totalDiamonds", totalDiamonds);
            isBought = 1;
            PlayerPrefs.SetInt("isBought", isBought);
        }

        else
        {
            NotEnoughGemsPanel.SetActive(true);
            BuyCheckPanel.SetActive(false);
        }
    }

    public void No()
    {
        BuyCheckPanel.SetActive(false);
    }

    public void CloseNotEnough()
    {
        NotEnoughGemsPanel.SetActive(false);
    }
}
