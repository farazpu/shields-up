using UnityEngine;
using System.Collections;

public class FriendlyCannon : MonoBehaviour {

	public GameObject powerBar;
	public Shields shields;
	public Gun gun;

	public int health = 100;

	public void TakeDemage() {
		health -= 20;
		Score.score -= 20;

	}

	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.Space)) {
			OnMouseUp();
		}

		if (health <= 0) {
			Destroy(gameObject);
			Score.score -= 40;
		} else {
			powerBar.GetComponent<SpriteRenderer>().color = Color.Lerp(Color.green, Color.red, 1 - (health * 0.01f));
			powerBar.transform.localScale = new Vector3(health * 0.01f, powerBar.transform.localScale.y);
		}
	}

	public void OnMouseUp() {
		//transform.Rotate (new Vector3 (0, 0, 30));
		gun.Fire (shields.GetSelectedShield());

	}
}
