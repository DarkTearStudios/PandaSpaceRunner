using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    public Text diamondCount;


    private void Awake()
    {
        diamondCount.text = PlayerPrefs.GetInt("totalDiamonds").ToString();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame ()
    {
        SceneManager.LoadScene(1);
    }
}
