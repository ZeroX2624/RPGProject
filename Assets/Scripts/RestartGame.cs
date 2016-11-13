using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class RestartGame : MonoBehaviour 
{

	public void OnStartButton()
	{
		SceneManager.LoadScene(0);
	}


}
