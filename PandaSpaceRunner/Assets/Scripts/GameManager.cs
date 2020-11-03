using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static GameManager instance;
    public bool gameOver;
    public bool GameOverSoundisPlaying;
    public GameObject GameOverSoundObject;
    public AudioClip GameOverAudioClip;
    AudioSource GameoverAudio;
    public GameObject Music;
    public GameObject FX;
    public int MusicToggle;
    public int FXToggle;
    public int ShowAd;


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        MusicToggle = PlayerPrefs.GetInt("Mute");
        FXToggle = PlayerPrefs.GetInt("MuteFX");
        ShowAd = PlayerPrefs.GetInt("ShowAd");


        if (FXToggle == 0)
        {
            FX.SetActive(true);

        }

        else
        {
            FX.SetActive(false);
        }
    }

	// Use this for initialization
	void Start ()
    {
        gameOver = false;
        GameoverAudio = GameOverSoundObject.GetComponent<AudioSource>();
        if (ShowAd < 5)
        {

        }
        GameOverSoundisPlaying = false;

    }
	
	// Update is called once per frame
	void Update ()
    {
        AndroidButtons();
    }

    public void StartGame()
    {
        if (MusicToggle == 0)
        {
            Music.SetActive(true);

        }

        else
        {
            Music.SetActive(false);
        }
        


        UiManager.instance.GameStart();
        ScoreManager.instance.startScore();
        GameObject.Find("PlatformSpawner").GetComponent<PlatformSpawner>().startSpawiningPlatforms();
    }

    public void GameOver()
    {
        Music.SetActive(false);
        UiManager.instance.GameOver();
        ScoreManager.instance.StopScore();
        if (!GameOverSoundisPlaying)
        {
            GameoverAudio.PlayOneShot(GameOverAudioClip, 0.3f);
            GameOverSoundisPlaying = true;
        }
        
        gameOver = true;
        
    }
    public void AndroidButtons()
    {
        if (Input.GetKey(KeyCode.Escape))
        {



            SceneManager.LoadScene(0);

        }

        if (Input.GetKey(KeyCode.Menu))
        {
            SceneManager.LoadScene(3);
        }
    }
}
