using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthManager : MonoBehaviour {

	public RPGcharacter attacker;
	public RPGcharacter defender;
	public Slider attackerHealthBar;
	public Slider defenderHealthBar;
	public Text attackerHP;
	public Text defenderHP;


	void Update () {
		//using this as example, convert to this context
		//health.maxValue = charName.maxHP;
		//health.value = Mathf.Lerp (health.value, charName.HP, Time.deltaTime * 50f);

		attackerHealthBar.maxValue = attacker.maxHP;
		attackerHealthBar.value = Mathf.Lerp (attackerHealthBar.value, attacker.HP, Time.deltaTime * 50f);

		defenderHealthBar.maxValue = defender.maxHP;
		defenderHealthBar.value = Mathf.Lerp (defenderHealthBar.value, defender.HP, Time.deltaTime * 50f);

		//hInfo.text = (health.value + "/" + health.maxValue);
		//hManager.attackerHP.text = (health.value + "/" + health.maxValue);

		attackerHP.text = (attackerHealthBar.value + "/" + attackerHealthBar.maxValue);
		defenderHP.text = (defenderHealthBar.value + "/" + defenderHealthBar.maxValue);

		//playerHPSlider.value = Mathf.Lerp(playerHPSlider.value, player.HP, Time.deltaTime * 5f);
		//playerHPSlider.maxValue = player.maxHP;
		//enemyHPSlider.value = enemy.HP;
		//enemyHPSlider.maxValue = enemy.maxHP;
	}

}
