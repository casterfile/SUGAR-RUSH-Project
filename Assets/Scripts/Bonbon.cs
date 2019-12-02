using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Bonbon : MonoBehaviour {
	public GameObject congrats;
	private bool lifeBool;
	void Start(){
		lifeBool = false;
	}
	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.tag == "Coin") {
			Statics.ScoreCount += 1;
			Destroy(col.gameObject);
			if (col.gameObject.name.Contains("coin")) 
				Statics.speed += 0.1f;
			else if (col.gameObject.name.Contains("ribbon")) {
				congrats.SetActive(true);
				Statics.speed = 0f;
				GetComponent<Animator>().speed = 0f;
			}
		}
		else if (col.gameObject.tag == "candy") {
			Destroy(col.gameObject);
			if (lifeBool == false) {
				lifeBool = true;
				if(Statics.LifeCount == 3){
					Statics.LifeCount = 2;
					lifeBool = false;
				}else if(Statics.LifeCount == 2){
					Statics.LifeCount = 1;
					lifeBool = false;
				}else if(Statics.LifeCount == 1){
					Statics.LifeCount = 0;
					lifeBool = false;
				}
			}

//			print ("Hello world: "+Statics.LifeCount);
		}


	}
	void Update() {
		GetComponent<Animator>().speed = Statics.speed;
	}
}