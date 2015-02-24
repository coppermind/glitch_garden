using UnityEngine;
using System.Collections;

public class Defender : MonoBehaviour {

	void Start () {
	
	}
	
	void Update () {
	
	}
	
	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.gameObject.tag == "Attacker") {
		
		} else if (collider.gameObject.tag == "AttackerProjectile") {
		
		}
	}
}
