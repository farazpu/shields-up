using UnityEngine;
using System.Collections;

public class TutorialScript : MonoBehaviour {
	public EnemyCannon enemyCannon;
	public Gun enemyGun;
	// Use this for initialization
	void Start () {
		enemyCannon.transform.Rotate (new Vector3 (0, 0, 55.4236f));
		int fireForce = enemyGun.fireForce;
		enemyGun.fireForce = 300;
		enemyGun.Fire (ColorEnum.red);
		enemyGun.Fire (ColorEnum.green);
		enemyGun.Fire (ColorEnum.purple);
		enemyGun.fireForce = fireForce;
		enemyCannon.transform.Rotate (new Vector3 (0, 0, -55.4236f));
	}
	
	// Update is called once per frame
	void Update () {

	}
}
