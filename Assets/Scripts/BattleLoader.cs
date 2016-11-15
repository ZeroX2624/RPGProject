using UnityEngine;
using System.Collections;

public class BattleLoaderTest : MonoBehaviour {

	public RPGcharacter player;
	public RPGcharacter enemy;

	public GameObject BattleSystem;
	public GameObject BattleStage;


	//public string stageName;

	void Start () {
		
		GameObject bSystem = Instantiate (BattleSystem);
		GameObject stage = Instantiate (BattleStage);

		BattleManager bManager = bSystem.GetComponentInChildren<BattleManager> ();
		bManager.player = player;
		bManager.enemy = enemy;

		bManager.onPlayerWin = PlayMovie;
		bManager.onEnemyWin = ReloadScene;
		bManager.OnGameOver = LoadScene;
	}

	void PlayMovie(){
		print ("player won! play a movie file");
	}


	void ReloadScene(){
		print ("player lost! let's restart the scene");
	}

	void LoadScene(){	
		UnityEngine.SceneManagement.SceneManager.LoadScene (8);
	}

}
