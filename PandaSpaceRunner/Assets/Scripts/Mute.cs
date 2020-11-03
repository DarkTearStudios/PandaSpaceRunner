using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteToggle : MonoBehaviour
{
    public int Mute;
    public int MuteFX;

    public Toggle MuterSwitch;
    public Toggle MuterFXSwitch;
    // Start is called before the first frame update

    private void Awake()
    {
        Mute = PlayerPrefs.GetInt("Mute");
        MuteFX = PlayerPrefs.GetInt("MuteFX");
    }
    void Start()
    {
        PlayerPrefs.SetInt("Mute", Mute);
        if (Mute == 1)
        {
            MuterSwitch.isOn = true;
        }

        PlayerPrefs.SetInt("MuteFX", MuteFX);
        if (MuteFX == 1)
        {
            MuterFXSwitch.isOn = true;
        }


    }

    // Update is called once per frame
    void Update()
    {
        if (MuterSwitch.isOn == false)
        {
            Mute = 0;
            PlayerPrefs.SetInt("Mute", Mute);
        }

        if (MuterFXSwitch.isOn == false)
        {
            MuteFX = 0;
            PlayerPrefs.SetInt("MuteFX", MuteFX);
        }
    }

    public void Muter()
    {
        Mute = 1;
        PlayerPrefs.SetInt("Mute", Mute);
    }

    public void MuterFX()
    {
        MuteFX = 1;
        PlayerPrefs.SetInt("MuteFX", MuteFX);
    }
}
