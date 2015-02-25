using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Health))]
public class Defender : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.gameObject.tag == "Attacker") {
		
		} else if (collider.gameObject.tag == "AttackerProjectile") {
		
		}
	}
}
