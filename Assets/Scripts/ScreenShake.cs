using UnityEngine;
using System.Collections;

public class ScreenShake : MonoBehaviour {

	public static float shakeDuration;


	void Update () {
		shakeDuration -= Time.deltaTime;
		if (shakeDuration < 0) {
			shakeDuration = 0;
		}

		this.transform.localPosition = Random.insideUnitSphere * shakeDuration;
	}
}
