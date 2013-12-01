using UnityEngine;
using System.Collections;

public class Messages : MonoBehaviour {

	public GameObject[] levelSplashes;
	public GameObject youWinSplash;
	public GameObject youLoseSplash;
	public GameObject draw;
	public GameObject paused;



	public void ShowLevelSplash(int level) {
		for (int i = 0; i < levelSplashes.Length; i++) {
			if(level - 1 == i) {
				levelSplashes[i].SetActive(true);
			} else {
				levelSplashes[i].SetActive(false);
			}
		}
	}

	public void HideAllSplashes() {
		for (int i = 0; i < levelSplashes.Length; i++) {
			levelSplashes[i].SetActive(false);
		}
		youWinSplash.SetActive (false);
		youLoseSplash.SetActive (false);
		draw.SetActive (false);
		paused.SetActive (false);
	}

	public void ShowYouWin() {
		youWinSplash.SetActive (true);
	}

	public void ShowYouLose() {
		youLoseSplash.SetActive (true);
	}
	
	public void ShowDraw() {
		draw.SetActive(true); 
	}
	
	public void ShowPaused() {
		paused.SetActive(true); 
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
