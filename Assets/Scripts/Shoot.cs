using UnityEngine;
using System.Collections;


public class Shoot : Ability {

	public override void PlayCastAnim (RPGcharacter caster)
	{
		{
			caster.cAnimate.PlayShootAnim ();

		}
	}

	public override void Cast (RPGcharacter caster, RPGcharacter target)
	{
		print ("Bang!");


		target.HP = target.HP - 10;

	}

}
