using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveGemsDev : MonoBehaviour
{

    public int TotalGems;
    // Start is called before the first frame update
    void Start()
    {
        TotalGems = PlayerPrefs.GetInt("totalDiamonds");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GiveGems()
    {
        TotalGems += 999;
        PlayerPrefs.SetInt("totalDiamonds", TotalGems);
    }
}
