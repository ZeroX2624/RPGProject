﻿using UnityEngine;
using System.Collections;

public class Fire : Ability {

	public override void Cast (RPGcharacter caster, RPGcharacter target)
	{
		print ("Burn!");

		caster.cAnimate.PlayFireAnim ();
		target.HP = target.HP - 10;

	}
}
