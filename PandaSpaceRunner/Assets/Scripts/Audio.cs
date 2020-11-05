using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Audio : MonoBehaviour
{
    public int Mute;
    public int MuteFX;

    public Toggle MuterSwitch;
    public Toggle MuterFXSwitch;

    private static Audio instance = null;
    
    public AudioClip[] musicbg;
    private int i;


    public static Audio Instance
    {
        get { return instance; }
    }


    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }

        Mute = PlayerPrefs.GetInt("Mute");
        MuteFX = PlayerPrefs.GetInt("MuteFX");

    }
    
    void Start()
    {
        i = Random.Range(0, musicbg.Length);
        StartCoroutine("Playlist");

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

    private void Update()
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

    IEnumerator Playlist()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.0f);
            if (!GetComponent<AudioSource>().isPlaying)
            {
                if (i != (musicbg.Length - 1))
                {
                    i++;
                    GetComponent<AudioSource>().clip = musicbg[i];
                    GetComponent<AudioSource>().Play();
                }
                else
                {
                    i = 0;
                    GetComponent<AudioSource>().clip = musicbg[i];
                    GetComponent<AudioSource>().Play();
                }
            }
        }
    }
}