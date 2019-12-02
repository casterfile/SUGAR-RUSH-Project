using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlGame : MonoBehaviour {

	private GameObject Heart_1,Heart_2,Heart_3;
	private GameObject Heart_1_Empty,Heart_2_Empty,Heart_3_Empty;
	private GameObject Pill_1,Pill_2,Pill_3;

	private GameObject congrats, sorry;
	// Use this for initialization
	void Start () {
		Statics.GameState = true;
		Heart_1 = GameObject.Find("Canvas/HeartList/Heart (1)/Heart");
		Heart_2 = GameObject.Find("Canvas/HeartList/Heart (2)/Heart");
		Heart_3 = GameObject.Find("Canvas/HeartList/Heart (3)/Heart");


		Heart_1_Empty = GameObject.Find("Canvas/HeartList/Heart (1)/HeartEmpty");
		Heart_2_Empty = GameObject.Find("Canvas/HeartList/Heart (2)/HeartEmpty");
		Heart_3_Empty = GameObject.Find("Canvas/HeartList/Heart (3)/HeartEmpty");

		Pill_1 = GameObject.Find("Canvas/PillList/Pill (0)");
		Pill_2 = GameObject.Find("Canvas/PillList/Pill (1)");
		Pill_3 = GameObject.Find("Canvas/PillList/Pill (2)");

		congrats = GameObject.Find("congrats");
		sorry = GameObject.Find("sorry");

		Pill_1.SetActive (false);
		Pill_2.SetActive (false);
		Pill_3.SetActive (false);

		congrats.SetActive (false);
		sorry.SetActive (false);
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Statics.LifeCount == 3) {
			Heart_1.SetActive (true);
			Heart_2.SetActive (true);
			Heart_3.SetActive (true);
		} else if(Statics.LifeCount == 2){
			Heart_1.SetActive (false);
			Heart_2.SetActive (true);
			Heart_3.SetActive (true);
		} else if(Statics.LifeCount == 1){
			Heart_1.SetActive (false);
			Heart_2.SetActive (false);
			Heart_3.SetActive (true);
		} else if(Statics.LifeCount == 0){
			Heart_1.SetActive (false);
			Heart_2.SetActive (false);
			Heart_3.SetActive (false);
			sorry.SetActive (true);
			Statics.GameState = false;
		}

		if (Statics.ScoreCount == 3) {
			congrats.SetActive (true);
			Pill_1.SetActive (true);
			Pill_2.SetActive (true);
			Pill_3.SetActive (true);
			Statics.GameState = false;
		}else if (Statics.ScoreCount == 2) {
			Pill_1.SetActive (true);
			Pill_2.SetActive (true);
			Pill_3.SetActive (false);
		}else if (Statics.ScoreCount == 1) {
			Pill_1.SetActive (true);
			Pill_2.SetActive (false);
			Pill_3.SetActive (false);
		}else if (Statics.ScoreCount == 0) {
			Pill_1.SetActive (false);
			Pill_2.SetActive (false);
			Pill_3.SetActive (false);
		}
		
	}
}
