using UnityEngine;
using System.Collections;

public class CharacterAnimator : MonoBehaviour {




	public void PlayAttackAnim(){
		GetComponent<Animator> ().Play ("Attack");
	
	}

	public void PlayShootAnim(){
		GetComponent<Animator> ().Play ("Shoot");

	}

	public void PlayFireAnim(){
		GetComponent<Animator> ().Play ("Fire");

	}

	public void PlayHealAnim(){
		GetComponent<Animator> ().Play ("Heal");

	}

	public void PlayTakeDamageAnim(){
		GetComponent<Animator> ().Play ("GetHit");
		ScreenShake.shakeDuration = .5f;
	}

	public void PlayDieAnim(){
		GetComponent<Animator> ().Play ("Dead");

	}

	public void PlayPunchAnim(){
		GetComponent<Animator> ().Play ("PunchTheSky");
	}
}
