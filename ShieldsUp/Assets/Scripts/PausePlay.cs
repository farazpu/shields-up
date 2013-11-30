using UnityEngine;
using System.Collections;

public class PausePlay : MonoBehaviour {

	public void OnMouseUp() {
		
		if (Time.timeScale == 0) {
			Time.timeScale = 1;
		} else {
			Time.timeScale = 0;
		}
	}
}
