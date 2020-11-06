using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public static ScoreManager instance;
    public int score;
    public int highScore;
    public int totalDiamonds;
    public int doubleDiamonds;
    public GameObject NewGemAmount;
    public GameObject OldGemAmount;
    public GameObject GemAnimation;
    public Text NewGemText;
    public int NewGemInt;
    public int ccheck;


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }

        ccheck = PlayerPrefs.GetInt("ccheck");
    }

	// Use this for initialization
	void Start () {
        score = 0;
        totalDiamonds = PlayerPrefs.GetInt("totalDiamonds", 0);
        PlayerPrefs.SetInt("score", score);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    
    public void diamondCount()
    {
        score += 1;
        totalDiamonds +=  1;
        doubleDiamonds += 1;
        if (totalDiamonds == 999 || totalDiamonds == 1000 )
        {
            ccheck = 1;
            PlayerPrefs.SetInt("ccheck", ccheck);
        }
        PlayerPrefs.SetInt("totalDiamonds", totalDiamonds);
        PlayerPrefs.Save();
        
       
    }

    public void DoubleDiamonds()
    {
        totalDiamonds += doubleDiamonds;
        PlayerPrefs.SetInt("totalDiamonds", totalDiamonds);

    }
    public void DoubleDiamondText()
    {
        NewGemInt = doubleDiamonds * 2;

        NewGemText.text = NewGemInt.ToString();

        OldGemAmount.SetActive(false);
        NewGemAmount.SetActive(true);
    }

    public void diamondSubtract ()
    {
        totalDiamonds = totalDiamonds - 1000;
        PlayerPrefs.SetInt("totalDiamonds", totalDiamonds);
    }

    

    public void incrementScore()
    {
        score += 1;
    }

    public void startScore()
    {
        InvokeRepeating("incrementScore", 0.1f, 1f);
        
    }

    public void StopScore()
    {
        CancelInvoke("incrementScore");
        PlayerPrefs.SetInt("score", score);
        if(PlayerPrefs.HasKey("highScore"))
        {
            if (score > PlayerPrefs.GetInt("highScore"))
            {
                PlayerPrefs.SetInt("highScore", score);
            }
        }
        else
        {
            PlayerPrefs.SetInt("highScore",score);
        }
    }

}
