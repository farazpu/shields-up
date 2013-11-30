using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	public static int score = 550;

	void Update() {
		gameObject.GetComponent<GUIText> ().text = "" + score;
	}
}
