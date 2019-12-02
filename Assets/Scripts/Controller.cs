using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Controller : MonoBehaviour {
	public float posVal;
	public GameObject bonbon;
	bool flag = false;
	string currentPosition = "";

	void Start(){
		Statics.ScoreCount = 0;
		Statics.LifeCount = 3;
	}
	void FixedUpdate() {
		bonbon.transform.position = Vector3.Lerp(bonbon.transform.position, new Vector3(Statics.pos, -3.35f, 0f), 0.03f);

	}
	void OnMouseDown() {
		flag = true;
	}
	void OnMouseUp() {
		if (flag && Statics.speed > 0f) {
			if (Statics.pos + posVal <= 1f && Statics.pos + posVal >= -2f) {
				Statics.pos += posVal;
			}	
		}
	}
}