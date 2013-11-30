using UnityEngine;
using System.Collections;

public class RestartLevel : MonoBehaviour {

	public void OnMouseUp() {

		Application.LoadLevel (Application.loadedLevelName);
		Score.ResetScore ();
	}
}
