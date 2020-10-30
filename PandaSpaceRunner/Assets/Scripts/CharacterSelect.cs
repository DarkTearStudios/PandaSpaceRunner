using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelect : MonoBehaviour
{

    public static CharacterSelect instance;
    public int[] CharacterSet;
    public int[] CameraSet;
    public int[] BuyCheck;
    public int BuyCheckStart;
    

    public GameObject[] Character;
    public GameObject[] Camera;
    public GameObject[] Selector;
    public GameObject[] BuyCheckButton;
    public GameObject[] DiamondCost;


    private void Awake()
    {
        BuyCheck[0] = PlayerPrefs.GetInt("BuyCheck0");
        BuyCheck[1] = PlayerPrefs.GetInt("BuyCheck1");
        BuyCheck[2] = PlayerPrefs.GetInt("BuyCheck2");
        BuyCheck[3] = PlayerPrefs.GetInt("BuyCheck3");
        BuyCheck[4] = PlayerPrefs.GetInt("BuyCheck4");

        if (PlayerPrefs.HasKey("Character0"))
        {
            if (PlayerPrefs.GetInt("Character0") == 1)
            {
                Selector[0].GetComponent<Toggle>().isOn = true;
            }

            else
            {
                Selector[0].GetComponent<Toggle>().isOn = false;
            }
        }

        else
        {
            Selector[0].GetComponent<Toggle>().isOn = true;
        }
        

        if (PlayerPrefs.GetInt("Character1") == 1)
        {
            Selector[1].GetComponent<Toggle>().isOn = true;
        }

        else
        {
            Selector[1].GetComponent<Toggle>().isOn = false;
        }

        if (PlayerPrefs.GetInt("Character2") == 1)
        {
            Selector[2].GetComponent<Toggle>().isOn = true;
        }

        else
        {
            Selector[2].GetComponent<Toggle>().isOn = false;
        }

        if (PlayerPrefs.GetInt("Character3") == 1)
        {
            Selector[3].GetComponent<Toggle>().isOn = true;
        }

        else
        {
            Selector[3].GetComponent<Toggle>().isOn = false;
        }

        if (PlayerPrefs.GetInt("Character4") == 1)
        {
            Selector[4].GetComponent<Toggle>().isOn = true;
        }

        else
        {
            Selector[4].GetComponent<Toggle>().isOn = false;
        }

        if (PlayerPrefs.GetInt("Character5") == 1)
        {
            Selector[5].GetComponent<Toggle>().isOn = true;
        }

        else
        {
            Selector[5].GetComponent<Toggle>().isOn = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

        if (PlayerPrefs.HasKey ("BuyCheckStart"))
        {
            Selector[0].GetComponent<Toggle>().interactable = true;



            if (BuyCheck[0] == 0)
            {
                Selector[1].GetComponent<Toggle>().interactable = false;
                BuyCheckButton[0].SetActive(true);
                

            }

            else
            {
                Selector[1].GetComponent<Toggle>().interactable = true;
                BuyCheckButton[0].SetActive(false);
                DiamondCost[0].SetActive(false);
            }

            if (BuyCheck[1] == 0)
            {
                Selector[2].GetComponent<Toggle>().interactable = false;
                BuyCheckButton[1].SetActive(true);


            }

            else
            {
                Selector[2].GetComponent<Toggle>().interactable = true;
                BuyCheckButton[1].SetActive(false);
                DiamondCost[1].SetActive(false);
            }

            if (BuyCheck[2] == 0)
            {
                Selector[3].GetComponent<Toggle>().interactable = false;
                BuyCheckButton[2].SetActive(true);


            }

            else
            {
                Selector[3].GetComponent<Toggle>().interactable = true;
                BuyCheckButton[2].SetActive(false);
                DiamondCost[2].SetActive(false);
            }

            if (BuyCheck[3] == 0)
            {
                Selector[4].GetComponent<Toggle>().interactable = false;
                BuyCheckButton[3].SetActive(true);


            }

            else
            {
                Selector[4].GetComponent<Toggle>().interactable = true;
                BuyCheckButton[3].SetActive(false);
                DiamondCost[3].SetActive(false);
            }

            if (BuyCheck[4] == 0)
            {
                Selector[5].GetComponent<Toggle>().interactable = false;
                BuyCheckButton[4].SetActive(true);


            }

            else
            {
                Selector[5].GetComponent<Toggle>().interactable = true;
                BuyCheckButton[4].SetActive(false);
                DiamondCost[4].SetActive(false);
            }

        }

        else
        {
            BuyCheckStart = 0;
            BuyCheck[0] = 0;
            BuyCheck[1] = 0;
            BuyCheck[2] = 0;
            BuyCheck[3] = 0;
            BuyCheck[4] = 0;
            PlayerPrefs.SetInt("BuyCheckStart", BuyCheckStart);
        }
        



    }

    // Update is called once per frame
    void Update()
    {
        



    }

    public void CharcterSelect0()
    {
        CharacterSet[0] = 1;
        CameraSet[0] = 1;
        

        PlayerPrefs.SetInt("Character0", CharacterSet[0]);
        PlayerPrefs.SetInt("Camera0", CameraSet[0]);
       


        CharacterSet[1] = 0;
        CharacterSet[2] = 0;
        CharacterSet[3] = 0;
        CharacterSet[4] = 0;
        CharacterSet[5] = 0;

        PlayerPrefs.SetInt("Character1", CharacterSet[1]);
        PlayerPrefs.SetInt("Character2", CharacterSet[2]);
        PlayerPrefs.SetInt("Character3", CharacterSet[3]);
        PlayerPrefs.SetInt("Character4", CharacterSet[4]);
        PlayerPrefs.SetInt("Character5", CharacterSet[5]);


        CameraSet[1] = 0;
        CameraSet[2] = 0;
        CameraSet[3] = 0;
        CameraSet[4] = 0;
        CameraSet[5] = 0;

        PlayerPrefs.SetInt("Camera1", CameraSet[1]);
        PlayerPrefs.SetInt("Camera2", CameraSet[2]);
        PlayerPrefs.SetInt("Camera3", CameraSet[3]);
        PlayerPrefs.SetInt("Camera4", CameraSet[4]);
        PlayerPrefs.SetInt("Camera5", CameraSet[5]);

        



    }

    public void CharcterSelect1()
    {
        CharacterSet[1] = 1;
        CameraSet[1] = 1;
        

        PlayerPrefs.SetInt("Character1", CharacterSet[1]);
        PlayerPrefs.SetInt("Camera1", CameraSet[1]);
        

        CharacterSet[0] = 0;
        CharacterSet[2] = 0;
        CharacterSet[3] = 0;
        CharacterSet[4] = 0;
        CharacterSet[5] = 0;

        PlayerPrefs.SetInt("Character0", CharacterSet[0]);
        PlayerPrefs.SetInt("Character2", CharacterSet[2]);
        PlayerPrefs.SetInt("Character3", CharacterSet[3]);
        PlayerPrefs.SetInt("Character4", CharacterSet[4]);
        PlayerPrefs.SetInt("Character5", CharacterSet[5]);

        CameraSet[0] = 0;
        CameraSet[2] = 0;
        CameraSet[3] = 0;
        CameraSet[4] = 0;
        CameraSet[5] = 0;

        PlayerPrefs.SetInt("Camera0", CameraSet[0]);
        PlayerPrefs.SetInt("Camera2", CameraSet[2]);
        PlayerPrefs.SetInt("Camera3", CameraSet[3]);
        PlayerPrefs.SetInt("Camera4", CameraSet[4]);
        PlayerPrefs.SetInt("Camera5", CameraSet[5]);

       



    }

    public void CharcterSelect2()
    {
        CharacterSet[2] = 1;
        CameraSet[2] = 1;
        

        PlayerPrefs.SetInt("Character2", CharacterSet[2]);
        PlayerPrefs.SetInt("Camera2", CameraSet[2]);
        

        CharacterSet[1] = 0;
        CharacterSet[0] = 0;
        CharacterSet[3] = 0;
        CharacterSet[4] = 0;
        CharacterSet[5] = 0;

        PlayerPrefs.SetInt("Character1", CharacterSet[1]);
        PlayerPrefs.SetInt("Character0", CharacterSet[0]);
        PlayerPrefs.SetInt("Character3", CharacterSet[3]);
        PlayerPrefs.SetInt("Character4", CharacterSet[4]);
        PlayerPrefs.SetInt("Character5", CharacterSet[5]);

        CameraSet[1] = 0;
        CameraSet[0] = 0;
        CameraSet[3] = 0;
        CameraSet[4] = 0;
        CameraSet[5] = 0;

        PlayerPrefs.SetInt("Camera1", CameraSet[1]);
        PlayerPrefs.SetInt("Camera0", CameraSet[0]);
        PlayerPrefs.SetInt("Camera3", CameraSet[3]);
        PlayerPrefs.SetInt("Camera4", CameraSet[4]);
        PlayerPrefs.SetInt("Camera5", CameraSet[5]);

        
    }

    public void CharcterSelect3()
    {
        CharacterSet[3] = 1;
        CameraSet[3] = 1;
        

        PlayerPrefs.SetInt("Character3", CharacterSet[3]);
        PlayerPrefs.SetInt("Camera3", CameraSet[3]);
       

        CharacterSet[1] = 0;
        CharacterSet[2] = 0;
        CharacterSet[0] = 0;
        CharacterSet[4] = 0;
        CharacterSet[5] = 0;

        PlayerPrefs.SetInt("Character1", CharacterSet[1]);
        PlayerPrefs.SetInt("Character2", CharacterSet[2]);
        PlayerPrefs.SetInt("Character0", CharacterSet[0]);
        PlayerPrefs.SetInt("Character4", CharacterSet[4]);
        PlayerPrefs.SetInt("Character5", CharacterSet[5]);

        CameraSet[1] = 0;
        CameraSet[2] = 0;
        CameraSet[0] = 0;
        CameraSet[4] = 0;
        CameraSet[5] = 0;

        PlayerPrefs.SetInt("Camera1", CameraSet[1]);
        PlayerPrefs.SetInt("Camera2", CameraSet[2]);
        PlayerPrefs.SetInt("Camera0", CameraSet[0]);
        PlayerPrefs.SetInt("Camera4", CameraSet[4]);
        PlayerPrefs.SetInt("Camera5", CameraSet[5]);

        
    }

    public void CharcterSelect4()
    {
        CharacterSet[4] = 1;
        CameraSet[4] = 1;
        

        PlayerPrefs.SetInt("Character4", CharacterSet[4]);
        PlayerPrefs.SetInt("Camera4", CameraSet[4]);
        

        CharacterSet[1] = 0;
        CharacterSet[2] = 0;
        CharacterSet[3] = 0;
        CharacterSet[0] = 0;
        CharacterSet[5] = 0;

        PlayerPrefs.SetInt("Character1", CharacterSet[1]);
        PlayerPrefs.SetInt("Character2", CharacterSet[2]);
        PlayerPrefs.SetInt("Character3", CharacterSet[3]);
        PlayerPrefs.SetInt("Character0", CharacterSet[0]);
        PlayerPrefs.SetInt("Character5", CharacterSet[5]);

        CameraSet[1] = 0;
        CameraSet[2] = 0;
        CameraSet[3] = 0;
        CameraSet[0] = 0;
        CameraSet[5] = 0;

        PlayerPrefs.SetInt("Camera1", CameraSet[1]);
        PlayerPrefs.SetInt("Camera2", CameraSet[2]);
        PlayerPrefs.SetInt("Camera3", CameraSet[3]);
        PlayerPrefs.SetInt("Camera0", CameraSet[0]);
        PlayerPrefs.SetInt("Camera5", CameraSet[5]);

        
    }

    public void CharcterSelect5()
    {
        CharacterSet[5] = 1;
        CameraSet[5] = 1;
        

        PlayerPrefs.SetInt("Character5", CharacterSet[5]);
        PlayerPrefs.SetInt("Camera5", CameraSet[5]);
        

        CharacterSet[1] = 0;
        CharacterSet[2] = 0;
        CharacterSet[3] = 0;
        CharacterSet[4] = 0;
        CharacterSet[0] = 0;

        PlayerPrefs.SetInt("Character1", CharacterSet[1]);
        PlayerPrefs.SetInt("Character2", CharacterSet[2]);
        PlayerPrefs.SetInt("Character3", CharacterSet[3]);
        PlayerPrefs.SetInt("Character4", CharacterSet[4]);
        PlayerPrefs.SetInt("Character0", CharacterSet[0]);

        CameraSet[1] = 0;
        CameraSet[2] = 0;
        CameraSet[3] = 0;
        CameraSet[4] = 0;
        CameraSet[0] = 0;

        PlayerPrefs.SetInt("Camera1", CameraSet[1]);
        PlayerPrefs.SetInt("Camera2", CameraSet[2]);
        PlayerPrefs.SetInt("Camera3", CameraSet[3]);
        PlayerPrefs.SetInt("Camera4", CameraSet[4]);
        PlayerPrefs.SetInt("Camera0", CameraSet[0]);

       
    }
}
