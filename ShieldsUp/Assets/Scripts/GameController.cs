using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

	public GameObject enemyCannon;
	public GameObject firemdlyCannon;
	public Messages messages;

	private float enemyY = 3.541778f;
	private float friendY = -2.698289f;

	private float startX = -1.080423f;
	private float gap = 2.519295f;


	private int currentLevel = 1;
	private bool setupLevel = true;

	private List<GameObject> enemies = new List<GameObject>();
	private List<GameObject> friends = new List<GameObject>();

	public int totalLevels = 3;

	private bool gameEnded = false;

	private bool setupLevelRunning = false;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (gameEnded) return;

		if (setupLevel) {
			setupLevel = false;
			StartCoroutine (SetupLevel ());
		} else if(!setupLevelRunning) {
			bool allEnemiesDead = true;
			foreach (var item in enemies) {
				if(item != null) {
					allEnemiesDead = false;
				}
			}

			if(allEnemiesDead) {
				if(currentLevel < totalLevels) {
					currentLevel++;
					setupLevel = true;
				} else {
					messages.ShowYouWin();
					gameEnded = true;
				}
				return;
			} else {
				bool allFriendsDead = true;
				foreach (var item in friends) {
					if(item != null) {
						allFriendsDead = false;
					}
				}

				if(allFriendsDead) {
					messages.ShowYouLose();
					gameEnded = true;
				} else {

					bool isDraw = true;

					for (int i = 0; i < enemies.Count; i++) {
						isDraw = (enemies[i] == null) != (friends[i] == null) && isDraw;
					}

					if(isDraw) {
						messages.ShowDraw();
						gameEnded = true;
					}

				}
			}
		}
	}

	private IEnumerator SetupLevel() {
		setupLevelRunning = true;

		foreach (var item in enemies) {
			Destroy(item);
		}
		
		foreach (var item in friends) {
			Destroy(item);
		}
		enemies = new List<GameObject> ();
		friends = new List<GameObject> ();

		messages.HideAllSplashes ();
		messages.ShowLevelSplash (currentLevel);
		yield return new WaitForSeconds (3);

		for (int i = 0; i < currentLevel; i++) {
			friends.Add(Instantiate(firemdlyCannon, new Vector3(startX + (gap * i), friendY, 1), Quaternion.identity) as GameObject);
			enemies.Add(Instantiate(enemyCannon, new Vector3(startX + (gap * i), enemyY, 1), Quaternion.AngleAxis(180, new Vector3(0,0,1))) as GameObject);
		}
		messages.HideAllSplashes ();
		setupLevelRunning = false;
	}
}
