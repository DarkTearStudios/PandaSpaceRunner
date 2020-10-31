using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

    public static ScoreManager instance;
    public int score;
    public int highScore;
    public int totalDiamonds;
    public int doubleDiamonds;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
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
        PlayerPrefs.SetInt("totalDiamonds", totalDiamonds);
        PlayerPrefs.Save();
        
       
    }

    public void DoubleDiamonds()
    {
        totalDiamonds += doubleDiamonds;
        PlayerPrefs.SetInt("totalDiamonds", totalDiamonds);

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
