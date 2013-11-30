using UnityEngine;
using System.Collections;

public class FriendlyCannonBall : MonoBehaviour {
	public ColorEnum color; 

	public void OnTriggerEnter2D (Collider2D coll) {
		HandleCollision (coll.gameObject);
	}
	
	private void HandleCollision(GameObject go) {
		if (go.tag == "EnemyCannonBalls") {

			if(go.GetComponent<EnemyCannonBall>().color == color) {
				go.transform.parent.gameObject.GetComponent<Gun>().ResetCannonBall(go);
				Score.score += 2;
			} else {
				Score.score -= 2;
			}
			transform.parent.gameObject.GetComponent<Gun>().ResetCannonBall(gameObject);
		}

		if (go.tag == "EnemyCennons") {
			
			go.GetComponent<EnemyCannon>().TakeDemage();
			transform.parent.gameObject.GetComponent<Gun>().ResetCannonBall(gameObject);
		}

	}
	
	public void OnCollisionEnter2D(Collision2D coll) {
		HandleCollision (coll.gameObject);
	}
}
