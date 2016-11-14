using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using System.Collections;

public class BattleManager : MonoBehaviour {

	public RPGcharacter player;
	public RPGcharacter enemy;

	public ButtonControl bControl;
	public Ability [] abilities;

	public Slider playerHPSlider;
	public Slider enemyHPSlider;

	public int turnCount;

	public System.Action onPlayerWin;
	public System.Action onEnemyWin;

	public Action OnGameOver;

	private IEnumerator coroutine;


	void Start (){
		turnCount = 0;
	}

	void Update(){

		if(player.HP <= 0)
		{
			print ("Game Over");
			bControl.DisableButton ();

		}
		if(enemy.HP <= 0)
		{
			print ("You Win");
			bControl.DisableButton ();
		}

		//playerHPSlider.value = Mathf.Lerp(playerHPSlider.value, player.HP, Time.deltaTime * 5f);
		//playerHPSlider.maxValue = player.maxHP;
		//enemyHPSlider.value = enemy.HP;
		//enemyHPSlider.maxValue = enemy.maxHP;

	}


	public void AdvanceTurn(Ability currentAbility){
		StartCoroutine (BattleRoutine (currentAbility));
	}

	void CheckIfBattleOver(){
		if (enemy.HP <= 0) {
			onPlayerWin ();
		}
		else if (player.HP <= 0) {
			onEnemyWin ();
		}
	}




	public void CheckifDead(RPGcharacter target){
		if (target.HP <= 0) {
			target.cAnimate.PlayDieAnim ();
			print ("dead");


			StopCoroutine (coroutine);
			OnGameOver ();

		}
	}

	IEnumerator BattleRoutine(Ability thisAbility){
		//userclicks attack
		yield return new WaitForSeconds(1f);

		//buttons disappear
		bControl.DisableButton();
		yield return new WaitForSeconds(1f);

		//attack animation
		//print ("player attacks");
		thisAbility.PlayCastAnim(player);
		thisAbility.PlayRecieveAnim(enemy);
		yield return new WaitForSeconds(2f);

		//update slider
		thisAbility.Cast(player, enemy);
		yield return new WaitForSeconds(0.5f);

		//check if HP is 0
		CheckifDead(enemy);

		//enemyattack animation
		//print ("enemy attacks");
		thisAbility.PlayCastAnim(enemy);
		thisAbility.PlayRecieveAnim (player);
		yield return new WaitForSeconds(2f);

		//apply damage
		thisAbility.Cast(enemy, player);
		yield return new WaitForSeconds(0.5f);

		//check if player is dead
		CheckifDead(player);

		//button come back
		bControl.EnableButton();

	}




}
