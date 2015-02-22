using UnityEngine;
using System.Collections;

public class DefenderProjectile : MonoBehaviour {

	public float damagePoints;

	void Start () {
	
	}
	
	void Update () {
	
	}
	
	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.gameObject.tag == "Attacker") {
			//Destroy(gameObject);
		}
	}
}
