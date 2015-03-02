using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Attacker))]
public class Lizard : MonoBehaviour {

	private Attacker attacker;
	
	void Start() {
		attacker = GetComponent<Attacker>();
	}

	void OnTriggerEnter2D (Collider2D collider) {
		GameObject collidedObject = collider.gameObject;
		
		if (collidedObject.GetComponent<Defender>()) {
			attacker.Attack(collidedObject);
		}
	}
}
