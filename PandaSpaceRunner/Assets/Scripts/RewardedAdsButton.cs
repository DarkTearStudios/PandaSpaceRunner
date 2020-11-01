using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

[RequireComponent(typeof(Button))]
public class RewardedAdsButton : MonoBehaviour, IUnityAdsListener
{
    public GameObject RewardButton;
    public GameObject GemAnimation;
    public GameObject NewGemAmount;
    public GameObject OldGemAmount;
    public Text NewGemText;
    public int NewGemInt;
    
    

#if UNITY_IOS
    private string gameId = "3883670";
#elif UNITY_ANDROID
    private string gameId = "3883671";
#endif

    Button myButton;
    public string myPlacementId = "rewardedVideo";

    void Start()
    {
        myButton = GetComponent<Button>();

        // Set interactivity to be dependent on the Placement’s status:
        myButton.interactable = Advertisement.IsReady(myPlacementId);

        // Map the ShowRewardedVideo function to the button’s click listener:
        if (myButton) myButton.onClick.AddListener(ShowRewardedVideo);

        // Initialize the Ads listener and service:
        Advertisement.AddListener(this);
        Advertisement.Initialize(gameId, true);
        NewGemAmount.SetActive(false);
    }

    // Implement a function for showing a rewarded video ad:
    void ShowRewardedVideo()
    {
        Advertisement.Show(myPlacementId);
        RewardButton.SetActive(false);
        
    }

  

    // Implement IUnityAdsListener interface methods:
    public void OnUnityAdsReady(string placementId)
    {
        // If the ready Placement is rewarded, activate the button: 
        if (placementId == myPlacementId)
        {
            myButton.interactable = true;
        }
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        // Define conditional logic for each ad completion status:
        
        
        if (showResult == ShowResult.Finished)
        {

            GemAnimation.SetActive(true);

            

            NewGemInt = ScoreManager.instance.doubleDiamonds * 2;

            NewGemText.text = NewGemInt.ToString();


        }
        else if (showResult == ShowResult.Skipped)
        {
            // Do not reward the user for skipping the ad.
        }
        else if (showResult == ShowResult.Failed)
        {
            Debug.LogWarning("The ad did not finish due to an error.");
        }
    }

    public void NeGemtext()
    {
        OldGemAmount.SetActive(false);

        NewGemAmount.SetActive(true);
    }

    public void OnUnityAdsDidError(string message)
    {
        // Log the error.
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        // Optional actions to take when the end-users triggers an ad.
    }
}
