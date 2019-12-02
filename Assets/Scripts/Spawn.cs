using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Spawn : MonoBehaviour {
	public GameObject[] coins = new GameObject[3];
	public GameObject[] trees = new GameObject[6];
	void Start() {
		InvokeRepeating("Withdraw", 0f, 3f);//coins
		//InvokeRepeating("Mokuton", 0f, 2f);//puno
	}
	void Withdraw() {
		if (Statics.GameState == true) {
			if (Statics.speed > 0f) {
				int rand = Random.Range(0, 3);
				Instantiate(coins[rand], new Vector3(0.8f, 1.78f, 0f), Quaternion.identity);
			}
		}

	}
	void Mokuton() {
		if (Statics.speed > 0f) {
			int leftRand = Random.Range(0, 6);
			int righttRand = Random.Range(0, 6);
			if (leftRand < 3)
				Instantiate(trees[leftRand], new Vector3(0.8f, 1.78f, 0f), Quaternion.identity);
			if (righttRand < 3)
				Instantiate(trees[righttRand + 3], new Vector3(0.8f, 1.78f, 0f), Quaternion.identity);
		}
	}
}