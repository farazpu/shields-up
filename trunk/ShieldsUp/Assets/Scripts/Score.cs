using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	private static int startScore = 550;

	public static int score = startScore;

	public static void ResetScore() {
		score = startScore;
	}

	void Update() {
		gameObject.GetComponent<GUIText> ().text = "" + score;
	}
}
