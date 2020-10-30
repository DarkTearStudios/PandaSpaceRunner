using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteToggle : MonoBehaviour
{
    public int Mute;

    public Toggle MuterSwitch;
    // Start is called before the first frame update

    private void Awake()
    {
        Mute = PlayerPrefs.GetInt("Mute");
    }
    void Start()
    {
        PlayerPrefs.SetInt("Mute", Mute);
        if (Mute == 1)
        {
            MuterSwitch.isOn = true;
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
    }

    public void Muter()
    {
        Mute = 1;
        PlayerPrefs.SetInt("Mute", Mute);
    }
}
