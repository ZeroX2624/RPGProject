using UnityEngine;
using System.Collections;

public class Ability : MonoBehaviour {

	public string abilityName;
	public int damage;
	public int accuracy;

	public virtual void PlayCastAnim (RPGcharacter caster){
		caster.cAnimate.PlayAttackAnim ();
	}

	public virtual void PlayRecieveAnim (RPGcharacter target){
		target.cAnimate.PlayTakeDamageAnim ();
	}

	public virtual void PlayDeadAnim (RPGcharacter target){
		target.cAnimate.PlayDieAnim ();
	}

	public virtual void Cast(RPGcharacter caster, RPGcharacter target){

		int totalDamage = caster.atk * damage / target.def;

		if(totalDamage <= 0)
		{
			totalDamage = 1;
		}

		//apply damage
		target.HP = target.HP - totalDamage;

		print (caster.charName + " is attacking!");
		print (caster.charName + " attacked " + target.charName + " for " + caster.atk);
		print ("damage is "+ totalDamage);
		//defender.HP = defender.HP - damage;
		print (target.charName + " HP:" + target.HP + "/" + target.maxHP);


	}
}
