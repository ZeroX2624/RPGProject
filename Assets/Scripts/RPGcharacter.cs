using UnityEngine;
using System.Collections;

public class RPGcharacter : MonoBehaviour {

	public string charName;
	public int HP;
	public int speed;
	public int atk;
	public int def;
	public int maxHP;

	public CharacterAnimator cAnimate;

	public Ability [] abilities;

}
