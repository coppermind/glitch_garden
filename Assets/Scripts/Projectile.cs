using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	public float damage;
	public float speed;
	
	void Update() {
		transform.Translate(Vector3.right * speed * Time.deltaTime);
	}
	
	void OnTriggerEnter2D(Collider2D collider) {
		GameObject attacker = collider.gameObject;
		
		if (attacker.tag == "Attacker") {
			Health health = attacker.GetComponent<Health>();
			health.HitWith(damage);
		}
	}
}
