using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Countdown : MonoBehaviour {
	int sec = 24;
	public GameObject[] bars = new GameObject[12];
	public GameObject ribbon;
	public GameObject congrats;
	public GameObject sorry;
	void Start() {
		InvokeRepeating("DecreaseSec", 1f, 1f);
	}
	void DecreaseSec() {
		if (sec > 0) {
			sec--;
			GetComponent<Text>().text = "" + sec;
			if (sec % 2 == 0) {
				Destroy(bars[sec / 2]);
			}
			if (sec == 0) {
				if (Statics.speed >= 1f)
					Instantiate(ribbon, new Vector3(0.8f, 1.78f, 0f), Quaternion.identity);
				else {
					sorry.SetActive(true);
					Statics.speed = 0f;
				}
			}
		}
	}
}