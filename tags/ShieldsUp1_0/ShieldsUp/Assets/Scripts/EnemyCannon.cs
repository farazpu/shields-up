using UnityEngine;
using System.Collections;

public class EnemyCannon : MonoBehaviour {

	public GameObject powerBar;
	public Gun gun;
	private bool fireGunRunning = false;

	public float fireInterval = 3;

	public int health = 100;

	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
		if (!fireGunRunning) {
			StartCoroutine(FireGun ());	
		}

		if (health <= 0) {
			Destroy(gameObject);
			Score.score += 40;
		} else {
			powerBar.GetComponent<SpriteRenderer>().color = Color.Lerp(Color.green, Color.red, 1 - (health * 0.01f));
			powerBar.transform.localScale = new Vector3(health * 0.01f, powerBar.transform.localScale.y);
		}
	}

	public void TakeDemage() {
		health -= 20;
		Score.score += 20;

	}
	
	public IEnumerator FireGun() {
		fireGunRunning = true;
		FireGunImmediately ();
		yield return new WaitForSeconds (fireInterval);
		fireGunRunning = false;
	}

	private void FireGunImmediately() {
		gun.Fire ((ColorEnum) Mathf.Floor(Random.Range(0, 2.99f)));
	}

	public void OnMouseUp() {
		FireGunImmediately ();
	}

}
