using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour {

    AsyncOperation loadingOperation;
    public static UiManager instance;
    public Slider progressBar;
    public GameObject precentText;
    public GameObject LoadSlider;
    public GameObject gameOverPanel;
    public GameObject tapText;
    public GameObject diamondCountPanel;
    public GameObject NotEnough;
    public GameObject [] SpendGemCheck;
    
   
    public Text percentLoaded;
    public Text diamondCount;
    public Text score;
    public Text highScore;
    public Text totalDiamonds;

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
        LoadSlider.SetActive(false);
        precentText.SetActive(false);
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
        totalDiamonds.text = ScoreManager.instance.doubleDiamonds.ToString();
        
        
    }

    public void StartGame()
    {
        loadingOperation = SceneManager.LoadSceneAsync(1);
        LoadSlider.SetActive(true);
        precentText.SetActive(true);
    }


    public void Reset()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void Home ()
    {
        SceneManager.LoadScene(0);
    }

    public void Shop()
    {
        SceneManager.LoadScene(2);
    }

    public void GemCheckOpen ()
    {
        SpendGemCheck[0].SetActive(true);
    }

    public void GemCheckOpen2()
    {
        SpendGemCheck[1].SetActive(true);
    }

    public void GemCheckOpen3()
    {
        SpendGemCheck[2].SetActive(true);
    }

    public void GemCheckOpen4()
    {
        SpendGemCheck[3].SetActive(true);
    }

    public void GemCheckOpen5()
    {
        SpendGemCheck[4].SetActive(true);
    }

    public void GemCheckClose()
    {
        SpendGemCheck[0].SetActive(false);
    }

    public void GemCheckClose2()
    {
        SpendGemCheck[1].SetActive(false);
    }

    public void GemCheckClose3()
    {
        SpendGemCheck[2].SetActive(false);
    }

    public void GemCheckClose4()
    {
        SpendGemCheck[3].SetActive(false);
    }

    public void GemCheckClose5()
    {
        SpendGemCheck[4].SetActive(false);
    }

    public void NotEnoughOpen()
    {
        NotEnough.SetActive(true);
    }

    public void NotEnoughClose()
    {
        NotEnough.SetActive(false);
    }

    public void Settings()
    {
        SceneManager.LoadScene(3);
    }

    



    // Update is called once per frame
    void Update () 
    {

        diamondCount.text = PlayerPrefs.GetInt("totalDiamonds").ToString();
        progressBar.value = Mathf.Clamp01(loadingOperation.progress / 0.9f);
        float progressValue = Mathf.Clamp01(loadingOperation.progress / 0.9f);
        percentLoaded.text = Mathf.Round(progressValue * 100) + "%";

    }
}
