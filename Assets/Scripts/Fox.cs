using UnityEngine;
using System.Collections;
using System;

[RequireComponent (typeof (Attacker))]
public class Fox : AttackerBase {

	private Attacker attacker;
	
	void Start() {
		attacker = GetComponent<Attacker>();
	}

	void OnTriggerEnter2D (Collider2D collider) {
		GameObject collidedObject = collider.gameObject;
		
		if (collidedObject.GetComponent<Defender>()) {
			if (collidedObject.GetComponent<Gravestone>()) {
				attacker.TriggerJump();
			} else {
				attacker.Attack(collidedObject);
			}
		}
	}

}
