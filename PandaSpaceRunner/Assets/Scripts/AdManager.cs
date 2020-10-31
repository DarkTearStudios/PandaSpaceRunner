using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdManager : MonoBehaviour
{
    public int ShowAdCount;
    


    public void Awake()
    {
        ShowAdCount = PlayerPrefs.GetInt("ShowAdCount");
    }

    public void Update()
    {
        
    }


    public void Start()
    {

        #if UNITY_ANDROID
                Advertisement.Initialize("3883671");
        #else 
                Advertisement.Initialize("3883670");

        #endif
       
    }

    public void ShowAd()
    {
        if (ShowAdCount < 7)
        {
            ShowAdCount += 1;
            PlayerPrefs.SetInt("ShowAdCount", ShowAdCount);
        }

        else
        {
            Advertisement.Show();
            ShowAdCount = 0;
            PlayerPrefs.SetInt("ShowAdCount", ShowAdCount);
        }
    }

    public void ShowRewardAd()
    {
        
    }
}
