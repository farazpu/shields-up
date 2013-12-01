using UnityEngine;
using System.Collections;

public class RestartLevel : MonoBehaviour {

	public void OnMouseUp() {

		if (Time.timeScale > 0) {
			Application.LoadLevel (Application.loadedLevelName);
			Score.ResetScore ();
		}
	}
}
