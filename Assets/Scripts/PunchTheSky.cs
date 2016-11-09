using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PunchTheSky : Ability {

	public override void PlayCastAnim (RPGcharacter caster)
	{
		{
			caster.cAnimate.PlayPunchAnim ();

		}
	}

	public override void Cast (RPGcharacter caster, RPGcharacter target)
	{
		print ("Huzzah!!!");

		target.HP = 0;
		caster.HP = 1;
		{
			//yield return new WaitForSeconds (2);
			//SceneManager.LoadScene (2);
	}

}
}