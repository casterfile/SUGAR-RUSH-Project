using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Cut : MonoBehaviour {
	void Use() {
		Destroy(gameObject);
	}
	void Update() {
		if(Statics.GameState == true){
			GetComponent<Animator>().speed = Statics.speed;
		}

	}
}