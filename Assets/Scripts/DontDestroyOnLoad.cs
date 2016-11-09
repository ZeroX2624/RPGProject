using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class DontDestroyOnLoad : MonoBehaviour {



	void Update()
	{
		Scene currentScene = SceneManager.GetActiveScene();
		string sceneName = currentScene.name;

		DontDestroyOnLoad (transform.gameObject);

		if (sceneName == "MainMenu") 
		{
			Destroy(this.gameObject);
		} 

	}


}