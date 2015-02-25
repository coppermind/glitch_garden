using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	public float damage;
	public float speed;
	
	void Update() {
		transform.Translate(Vector3.right * speed * Time.deltaTime);
	}
	
	void OnTriggerEnter2D(Collider2D collider) {
		GameObject tagged = collider.gameObject;
		
		if (tagged.tag == "Attacker") {
			Health health = tagged.GetComponent<Health>();
			health.HitWith(damage);
			Destroy(gameObject);
		}
		
		if (tagged.tag == "Shredder") {
			Destroy(gameObject);
		}
	}
}
