using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextScene : MonoBehaviour {
	// Update is called once per frame
	public void ChangeString (string SceneName) {
		Application.LoadLevel(SceneName);
	}
}
