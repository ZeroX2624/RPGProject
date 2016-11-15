using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthBar : MonoBehaviour {

	public RPGcharacter charName;
	public Slider health;
	public BattleManager bManager;
	public HealthManager hManager;
	public Text hInfo;






	void Update () {
		health.maxValue = charName.maxHP;
		health.value = Mathf.Lerp (health.value, charName.HP, Time.deltaTime * 50f);


		hInfo.text = (health.value + "/" + health.maxValue);
		hManager.attackerHP.text = (health.value + "/" + health.maxValue);
	}
}
