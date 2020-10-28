using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CharacterPlay : MonoBehaviour
{

    public int[] CharacterSet;
    public int[] CameraSet;
    public int[] BackgroundSet;

    public GameObject[] Character;
    public GameObject[] Camera;
    public GameObject[] Background;

    private void Awake()
    {
        CharacterSet[0] = PlayerPrefs.GetInt("Character0");
        CharacterSet[1] = PlayerPrefs.GetInt("Character1");
        CharacterSet[2] = PlayerPrefs.GetInt("Character2");
        CharacterSet[3] = PlayerPrefs.GetInt("Character3");
        CharacterSet[4] = PlayerPrefs.GetInt("Character4");
        CharacterSet[5] = PlayerPrefs.GetInt("Character5");

        CameraSet[0] = PlayerPrefs.GetInt("Camera0");
        CameraSet[1] = PlayerPrefs.GetInt("Camera1");
        CameraSet[2] = PlayerPrefs.GetInt("Camera2");
        CameraSet[3] = PlayerPrefs.GetInt("Camera3");
        CameraSet[4] = PlayerPrefs.GetInt("Camera4");
        CameraSet[5] = PlayerPrefs.GetInt("Camera5");

        BackgroundSet[0] = PlayerPrefs.GetInt("Background0");
        BackgroundSet[1] = PlayerPrefs.GetInt("Background1");
        BackgroundSet[2] = PlayerPrefs.GetInt("Background2");
        BackgroundSet[3] = PlayerPrefs.GetInt("Background3");
        BackgroundSet[4] = PlayerPrefs.GetInt("Background4");
        BackgroundSet[5] = PlayerPrefs.GetInt("Background5");
    }
    // Start is called before the first frame update
    void Start()
    {
        

        

        if (PlayerPrefs.GetInt("Character0") == 1)
        {
            Character[0].SetActive(true);
            Character[1].SetActive(false);
            Character[2].SetActive(false);
            Character[3].SetActive(false);
            Character[4].SetActive(false);
            Character[5].SetActive(false);

            Camera[0].SetActive(true);
            Camera[1].SetActive(false);
            Camera[2].SetActive(false);
            Camera[3].SetActive(false);
            Camera[4].SetActive(false);
            Camera[5].SetActive(false);

            Background[0].SetActive(true);
            Background[1].SetActive(false);
            Background[2].SetActive(false);
            Background[3].SetActive(false);
            Background[4].SetActive(false);
            Background[5].SetActive(false);
        }

        if (PlayerPrefs.GetInt("Character1") == 1)
        {
            Character[1].SetActive(true);
            Character[0].SetActive(false);
            Character[2].SetActive(false);
            Character[3].SetActive(false);
            Character[4].SetActive(false);
            Character[5].SetActive(false);

            Camera[1].SetActive(true);
            Camera[0].SetActive(false);
            Camera[2].SetActive(false);
            Camera[3].SetActive(false);
            Camera[4].SetActive(false);
            Camera[5].SetActive(false);

            Background[1].SetActive(true);
            Background[0].SetActive(false);
            Background[2].SetActive(false);
            Background[3].SetActive(false);
            Background[4].SetActive(false);
            Background[5].SetActive(false);
        }

        if (PlayerPrefs.GetInt("Character2") == 1)
        {
            Character[0].SetActive(false);
            Character[1].SetActive(false);
            Character[2].SetActive(true);
            Character[3].SetActive(false);
            Character[4].SetActive(false);
            Character[5].SetActive(false);

            Camera[0].SetActive(false);
            Camera[1].SetActive(false);
            Camera[2].SetActive(true);
            Camera[3].SetActive(false);
            Camera[4].SetActive(false);
            Camera[5].SetActive(false);

            Background[0].SetActive(false);
            Background[1].SetActive(false);
            Background[2].SetActive(true);
            Background[3].SetActive(false);
            Background[4].SetActive(false);
            Background[5].SetActive(false);
        }

        if (PlayerPrefs.GetInt("Character3") == 1)
        {
            Character[0].SetActive(false);
            Character[1].SetActive(false);
            Character[2].SetActive(false);
            Character[3].SetActive(true);
            Character[4].SetActive(false);
            Character[5].SetActive(false);

            Camera[0].SetActive(false);
            Camera[1].SetActive(false);
            Camera[2].SetActive(false);
            Camera[3].SetActive(true);
            Camera[4].SetActive(false);
            Camera[5].SetActive(false);

            Background[0].SetActive(false);
            Background[1].SetActive(false);
            Background[2].SetActive(false);
            Background[3].SetActive(true);
            Background[4].SetActive(false);
            Background[5].SetActive(false);
        }

        if (PlayerPrefs.GetInt("Character4") == 1)
        {
            Character[0].SetActive(false);
            Character[1].SetActive(false);
            Character[2].SetActive(false);
            Character[3].SetActive(false);
            Character[4].SetActive(true);
            Character[5].SetActive(false);

            Camera[0].SetActive(false);
            Camera[1].SetActive(false);
            Camera[2].SetActive(false);
            Camera[3].SetActive(false);
            Camera[4].SetActive(true);
            Camera[5].SetActive(false);

            Background[0].SetActive(false);
            Background[1].SetActive(false);
            Background[2].SetActive(false);
            Background[3].SetActive(false);
            Background[4].SetActive(true);
            Background[5].SetActive(false);
        }

        if (PlayerPrefs.GetInt("Character5") == 1)
        {
            Character[0].SetActive(false);
            Character[1].SetActive(false);
            Character[2].SetActive(false);
            Character[3].SetActive(false);
            Character[4].SetActive(false);
            Character[5].SetActive(true);

            Camera[0].SetActive(false);
            Camera[1].SetActive(false);
            Camera[2].SetActive(false);
            Camera[3].SetActive(false);
            Camera[4].SetActive(false);
            Camera[5].SetActive(true);

            Background[0].SetActive(false);
            Background[1].SetActive(false);
            Background[2].SetActive(false);
            Background[3].SetActive(false);
            Background[4].SetActive(false);
            Background[5].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
