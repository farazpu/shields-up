using UnityEngine;
using System.Collections;

public class Shields : MonoBehaviour {

	public GameObject[] shields;
	
	public ColorEnum startShield;
	
	// Use this for initialization
	void Start () {
		SetActiveShiled (startShield);
	}
	
	public void SetActiveShiled(ColorEnum activeShield) {
		for (int i = 0; i < shields.Length; i++) {
			if(i == (int)activeShield)
				shields[i].SetActive (true);
			else
				shields[i].SetActive (false);

		}
	}
	
	public ColorEnum GetSelectedShield() {
		for (int i = 0; i < shields.Length; i++) {
			if(shields[i].activeSelf)
				return (ColorEnum)i;
		}
		return ColorEnum.purple;
	}
	
	public void RotateShield() {
		int nextSelected = ((int)GetSelectedShield ()) + 1;
		
		if (nextSelected >= shields.Length)
			nextSelected = 0;
		
		SetActiveShiled ((ColorEnum)nextSelected);
	}
	
	public void OnMouseUp () {
		RotateShield ();
	}

	public void Break() {
		gameObject.GetComponent<Animator> ().enabled = true;
		Score.score -= 30;

	}

}
