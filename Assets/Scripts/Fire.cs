using UnityEngine;
using System.Collections;

public class Fire : Ability {


	public override void PlayCastAnim (RPGcharacter caster)
	{
		{
			caster.cAnimate.PlayFireAnim ();

		}
	}

	public override void Cast (RPGcharacter caster, RPGcharacter target)
	{
		print ("Burn!");


		target.HP = target.HP - 10;



	}
}
