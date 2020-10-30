using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static GameManager instance;
    public bool gameOver;
    public GameObject Music;
    public int MusicToggle;
    public int ShowAd;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        MusicToggle = PlayerPrefs.GetInt("Mute");
        ShowAd = PlayerPrefs.GetInt("ShowAd");
    }

	// Use this for initialization
	void Start ()
    {
        gameOver = false;

        if (ShowAd < 5)
        {

        }
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
