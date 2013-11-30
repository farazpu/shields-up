using UnityEngine;
using System.Collections;

public class ReturnCannonBall : MonoBehaviour {
	public void OnTriggerEnter2D (Collider2D coll) {
		HandleCollision (coll.gameObject);
	}

	private void HandleCollision(GameObject go) {
		if (go.tag == "FriendlyCannonBalls" || go.tag == "EnemyCannonBalls") {
			go.transform.parent.gameObject.GetComponent<Gun>().ResetCannonBall(go);
		}
	}

	public void OnCollisionEnter2D(Collision2D coll) {
		HandleCollision (coll.gameObject);
	}
}
