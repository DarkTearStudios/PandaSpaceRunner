using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPlay : MonoBehaviour
{

    public int[] CharacterSet;
    public int[] CameraSet;
    public int[] BackgroundSet;

    public GameObject[] Character;
    public GameObject[] Camera;
    public GameObject[] Background;
   

    // Start is called before the first frame update
    void Start()
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
