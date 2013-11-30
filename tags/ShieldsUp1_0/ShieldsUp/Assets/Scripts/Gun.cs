using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Gun : MonoBehaviour {
	public GameObject purpleCannonBall;
	public GameObject redCannonBall;
	public GameObject greenCannonBall;

	public int fireForce = 50;

	Dictionary<GameObject, bool> fired = new Dictionary<GameObject, bool>();
	// Use this for initialization
	void Start () {
		fired.Add (purpleCannonBall, false);
		fired.Add (redCannonBall, false);
		fired.Add (greenCannonBall, false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	/**
	 * 0 - purple
	 * 1 - red
	 * 2 - green
	 */
	public void Fire(ColorEnum color) {
		GameObject targetObject = null;
		if (color == ColorEnum.purple)
			targetObject = purpleCannonBall;
		if(color == ColorEnum.red)
			targetObject = redCannonBall;
		if(color == ColorEnum.green)
			targetObject = greenCannonBall;

		if (!fired [targetObject]) {
			targetObject.rigidbody2D.AddForce (transform.up * fireForce);
			//targetObject.collider2D.isTrigger = false;
			fired [targetObject] = true;
		}
	}

	public void ResetCannonBall(GameObject cannonBall) {
		cannonBall.transform.position = transform.position;
		cannonBall.rigidbody2D.velocity = Vector2.zero;
		cannonBall.rigidbody2D.angularVelocity = 0f;

		//cannonBall.collider2D.isTrigger = false;

		
		fired [cannonBall] = false;

	}
}
