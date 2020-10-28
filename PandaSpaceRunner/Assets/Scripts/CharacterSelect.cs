using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelect : MonoBehaviour
{

    public int[] CharacterSet;
    public int[] CameraSet;
    public int[] BackgroundSet;

    public GameObject[] Character;
    public GameObject[] Camera;
    public GameObject[] Background;
    public GameObject[] Selector;


    private void Awake()
    {
        if (PlayerPrefs.GetInt("Character0") == 1)
        {
            Selector[0].GetComponent<Toggle>().isOn = true;
        }

        else
        {
            Selector[0].GetComponent<Toggle>().isOn = false;
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
        Selector[0].GetComponent<Toggle>().interactable = true;
        Selector[1].GetComponent<Toggle>().interactable = true;
        Selector[2].GetComponent<Toggle>().interactable = true;
        Selector[3].GetComponent<Toggle>().interactable = true;
        Selector[4].GetComponent<Toggle>().interactable = true;
        Selector[5].GetComponent<Toggle>().interactable = true;
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void CharcterSelect0()
    {
        CharacterSet[0] = 1;
        CameraSet[0] = 1;
        BackgroundSet[0] = 1;

        PlayerPrefs.SetInt("Character0", CharacterSet[0]);
        PlayerPrefs.SetInt("Camera0", CameraSet[0]);
        PlayerPrefs.SetInt("Background0", BackgroundSet[0]);


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

        BackgroundSet[1] = 0;
        BackgroundSet[2] = 0;
        BackgroundSet[3] = 0;
        BackgroundSet[4] = 0;
        BackgroundSet[5] = 0;

        PlayerPrefs.SetInt("Background1", BackgroundSet[1]);
        PlayerPrefs.SetInt("Background2", BackgroundSet[2]);
        PlayerPrefs.SetInt("Background3", BackgroundSet[3]);
        PlayerPrefs.SetInt("Background4", BackgroundSet[4]);
        PlayerPrefs.SetInt("Background5", BackgroundSet[5]);



    }

    public void CharcterSelect1()
    {
        CharacterSet[1] = 1;
        CameraSet[1] = 1;
        BackgroundSet[1] = 1;

        PlayerPrefs.SetInt("Character1", CharacterSet[1]);
        PlayerPrefs.SetInt("Camera1", CameraSet[1]);
        PlayerPrefs.SetInt("Background1", BackgroundSet[1]);

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

        BackgroundSet[0] = 0;
        BackgroundSet[2] = 0;
        BackgroundSet[3] = 0;
        BackgroundSet[4] = 0;
        BackgroundSet[5] = 0;

        PlayerPrefs.SetInt("Background0", BackgroundSet[0]);
        PlayerPrefs.SetInt("Background2", BackgroundSet[2]);
        PlayerPrefs.SetInt("Background3", BackgroundSet[3]);
        PlayerPrefs.SetInt("Background4", BackgroundSet[4]);
        PlayerPrefs.SetInt("Background5", BackgroundSet[5]);



    }

    public void CharcterSelect2()
    {
        CharacterSet[2] = 1;
        CameraSet[2] = 1;
        BackgroundSet[2] = 1;

        PlayerPrefs.SetInt("Character2", CharacterSet[2]);
        PlayerPrefs.SetInt("Camera2", CameraSet[2]);
        PlayerPrefs.SetInt("Background2", BackgroundSet[2]);

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

        BackgroundSet[1] = 0;
        BackgroundSet[0] = 0;
        BackgroundSet[3] = 0;
        BackgroundSet[4] = 0;
        BackgroundSet[5] = 0;

        PlayerPrefs.SetInt("Background1", BackgroundSet[1]);
        PlayerPrefs.SetInt("Background0", BackgroundSet[0]);
        PlayerPrefs.SetInt("Background3", BackgroundSet[3]);
        PlayerPrefs.SetInt("Background4", BackgroundSet[4]);
        PlayerPrefs.SetInt("Background5", BackgroundSet[5]);
    }

    public void CharcterSelect3()
    {
        CharacterSet[3] = 1;
        CameraSet[3] = 1;
        BackgroundSet[3] = 1;

        PlayerPrefs.SetInt("Character3", CharacterSet[3]);
        PlayerPrefs.SetInt("Camera3", CameraSet[3]);
        PlayerPrefs.SetInt("Background3", BackgroundSet[3]);

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

        BackgroundSet[1] = 0;
        BackgroundSet[2] = 0;
        BackgroundSet[0] = 0;
        BackgroundSet[4] = 0;
        BackgroundSet[5] = 0;

        PlayerPrefs.SetInt("Background1", BackgroundSet[1]);
        PlayerPrefs.SetInt("Background2", BackgroundSet[2]);
        PlayerPrefs.SetInt("Background0", BackgroundSet[0]);
        PlayerPrefs.SetInt("Background4", BackgroundSet[4]);
        PlayerPrefs.SetInt("Background5", BackgroundSet[5]);
    }

    public void CharcterSelect4()
    {
        CharacterSet[4] = 1;
        CameraSet[4] = 1;
        BackgroundSet[4] = 1;

        PlayerPrefs.SetInt("Character4", CharacterSet[4]);
        PlayerPrefs.SetInt("Camera4", CameraSet[4]);
        PlayerPrefs.SetInt("Background4", BackgroundSet[4]);

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

        BackgroundSet[1] = 0;
        BackgroundSet[2] = 0;
        BackgroundSet[3] = 0;
        BackgroundSet[0] = 0;
        BackgroundSet[5] = 0;

        PlayerPrefs.SetInt("Background1", BackgroundSet[1]);
        PlayerPrefs.SetInt("Background2", BackgroundSet[2]);
        PlayerPrefs.SetInt("Background3", BackgroundSet[3]);
        PlayerPrefs.SetInt("Background0", BackgroundSet[0]);
        PlayerPrefs.SetInt("Background5", BackgroundSet[5]);
    }

    public void CharcterSelect5()
    {
        CharacterSet[5] = 1;
        CameraSet[5] = 1;
        BackgroundSet[5] = 1;

        PlayerPrefs.SetInt("Character5", CharacterSet[5]);
        PlayerPrefs.SetInt("Camera5", CameraSet[5]);
        PlayerPrefs.SetInt("Background5", BackgroundSet[5]);

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

        BackgroundSet[1] = 0;
        BackgroundSet[2] = 0;
        BackgroundSet[3] = 0;
        BackgroundSet[4] = 0;
        BackgroundSet[0] = 0;

        PlayerPrefs.SetInt("Background1", BackgroundSet[1]);
        PlayerPrefs.SetInt("Background2", BackgroundSet[2]);
        PlayerPrefs.SetInt("Background3", BackgroundSet[3]);
        PlayerPrefs.SetInt("Background4", BackgroundSet[4]);
        PlayerPrefs.SetInt("Background0", BackgroundSet[0]);
    }
}
