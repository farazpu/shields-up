using UnityEngine;
using System.Collections;

public class PausePlay : MonoBehaviour {
	public Messages messages;
	public void OnMouseUp() {
		
		if (Time.timeScale == 0) {
			Time.timeScale = 1;
			messages.HideAllSplashes();
		} else {
			Time.timeScale = 0;
			messages.ShowPaused();
		}
	}
}
