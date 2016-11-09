using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenuCallbacks : MonoBehaviour 
{

	public void OnStartButton()
	{
		SceneManager.LoadScene(1);
	}


}
