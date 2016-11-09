using UnityEngine;
using System.Collections;

public class FullHeal : Ability {

	public override void PlayRecieveAnim (RPGcharacter caster)
	{
		{
			caster.cAnimate.PlayHealAnim ();

		}
	}

	public override void Cast (RPGcharacter caster, RPGcharacter target)
	{ 
		caster.HP = caster.maxHP;
	}

}
