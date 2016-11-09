using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonControl : MonoBehaviour {

	public Button button1;
	public Button button2;
	public Button button3;
	public Button button4;

	public BattleManager bManager;


	void Start() {
		button1.GetComponentInChildren<Text> ().text = bManager.player.abilities[0].abilityName;
		button1.onClick.AddListener (() => {
			bManager.AdvanceTurn(bManager.player.abilities[0]);

		});
		button2.GetComponentInChildren<Text> ().text = bManager.player.abilities[1].abilityName;	
		button2.onClick.AddListener (() => {
			bManager.AdvanceTurn(bManager.player.abilities[1]);

		});
		button3.GetComponentInChildren<Text> ().text = bManager.player.abilities[2].abilityName;
		button3.onClick.AddListener (() => {
			bManager.AdvanceTurn(bManager.player.abilities[2]);

		});
		button4.GetComponentInChildren<Text> ().text = bManager.player.abilities[3].abilityName;
		button4.onClick.AddListener (() => {
			bManager.AdvanceTurn(bManager.player.abilities[3]);

		});
	}

	public void DisableButton (){
		button1.interactable = false;
		button2.interactable = false;
		button3.interactable = false;
		button4.interactable = false;

	}

	public void EnableButton (){
		button1.interactable = true;
		button2.interactable = true;
		button3.interactable = true;
		button4.interactable = true;

	}
}

