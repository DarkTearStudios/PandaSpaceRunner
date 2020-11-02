using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Liscence : MonoBehaviour
{
	public void DeleteAll()
	{
		foreach (GameObject o in Object.FindObjectsOfType<GameObject>())
		{
			Destroy(o);
		}
	}

	public void Back()
	{
		DeleteAll();
		SceneManager.LoadScene(4);
	}
}
