using UnityEngine;
using System.Collections;

public class DefenderProjectile : MonoBehaviour {

	public float damagePoints;
	
	void OnTriggerEnter2D(Collider2D collider) {
		GameObject attacker = collider.gameObject;
		
		if (attacker.tag == "Attacker") {
			Health health = attacker.GetComponent<Health>();
			health.HitWith(damagePoints);
		}
	}
}
