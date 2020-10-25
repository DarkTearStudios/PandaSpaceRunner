using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour {

    public static UiManager instance;

    
    public GameObject gameOverPanel;
    public GameObject tapText;
    public GameObject diamondCountPanel;
    public Text diamondCount;
    public Text score;
    public Text highScore;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

    }

	// Use this for initialization
	void Start () 
    {
       
    }

    public void GameStart()
    {
        tapText.SetActive(false);
        diamondCountPanel.SetActive(true);
        score.text = PlayerPrefs.GetInt("score").ToString();
        diamondCount.text = PlayerPrefs.GetInt("totalDiamonds").ToString();

    }

    public void GameOver()
    {

        ScoreManager.instance.StopScore();
        score.text = PlayerPrefs.GetInt ("score").ToString();
        highScore.text = PlayerPrefs.GetInt("highScore").ToString();
        gameOverPanel.SetActive(true);
        diamondCountPanel.SetActive(false);
        
    }

    public void Reset()
    {
        SceneManager.LoadScene(1);
    }

    public void Home ()
    {
        SceneManager.LoadScene(0);
    }

    public void Shop()
    {
        SceneManager.LoadScene(2);
    }

    // Update is called once per frame
    void Update () 
    {

        diamondCount.text = PlayerPrefs.GetInt("totalDiamonds").ToString();

    }
}
