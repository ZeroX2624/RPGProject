using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class OnCollisionLoadScene : MonoBehaviour 
{

	void OnCollisionEnter(Collision asdf)
	{
		GameObject other = asdf.gameObject;
		if (other.gameObject.tag == "DeathRock")
		{
			int currentSceneNumber = SceneManager.GetActiveScene().buildIndex;
			int nextSceneNumber = currentSceneNumber + 1;
			SceneManager.LoadScene(nextSceneNumber);
		}
	}


}
