using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Game_ButtonFunctions : MonoBehaviour {
	
	public AudioClip clickSound;

	void Update(){
		//If touch back on mobile and in INGAME state
		if (Input.GetKeyDown (KeyCode.Escape) && GameManager2.instance.currentState == GameStates.INGAME) { 
			GameManager2.instance.Pause();
		}

		//If touch back on mobile and in PREGAME state
		if (Input.GetKeyDown (KeyCode.Escape) && GameManager2.instance.currentState == GameStates.PREGAME) { 
			#if UNITY_EDITOR
				UnityEditor.EditorApplication.isPlaying = false; //Stop UnityEditor
			#else
				Application.Quit();
			#endif
		}
	}

	public void OnClick(string buttonName){

		SoundManager.instance.playSingleSoundEffect(clickSound);

		switch (buttonName) {
			case "Restart" :
					Time.timeScale = 1;
					SceneManager.LoadScene(4);
					break;

			case "Pause" :
				GameManager2.instance.Pause();
				break;

			case "Resume" :
				GameManager2.instance.Resume();
				break;

			case "Rate" :
				//Put your URL
				Application.OpenURL ("https://play.google.com/store/apps/details?id=com.example"); 
				break;
				
			case "MuteMusic" :
				SoundManager.instance.muteMusic(); 
				break;
				
			case "MuteSoundEffect" :
				SoundManager.instance.muteSoundEffect();
				break;
		}
	}
}