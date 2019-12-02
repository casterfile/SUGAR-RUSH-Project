using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Click : MonoBehaviour {
	public int scene = -1;
	bool flag = false;
	void OnMouseDown() {
		flag = true;
	}
	void OnMouseUp() {
		if (flag) {
			Statics.pos = -0.5f;
			Statics.speed = 0.4f;
			SceneManager.LoadScene(scene);
		}
	}
}