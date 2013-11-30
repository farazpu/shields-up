using UnityEngine;
using System.Collections;

public class EnemyCannonBall : MonoBehaviour {

	public ColorEnum color; //

	public void OnTriggerEnter2D (Collider2D coll) {
		HandleCollision (coll.gameObject);
	}
	
	private void HandleCollision(GameObject go) {
		if (go.tag == "Shields") {
			
			if(go.GetComponent<Shields>().GetSelectedShield() != color) {
				go.GetComponent<Shields>().Break();
			} else {
				Score.score += 2;
			}
			transform.parent.gameObject.GetComponent<Gun>().ResetCannonBall(gameObject);
		}
		
		
		if (go.tag == "FriendlyCannons") {
			
			go.GetComponent<FriendlyCannon>().TakeDemage();
			transform.parent.gameObject.GetComponent<Gun>().ResetCannonBall(gameObject);
		}
		
	}
	
	public void OnCollisionEnter2D(Collision2D coll) {
		HandleCollision (coll.gameObject);
	}
}
