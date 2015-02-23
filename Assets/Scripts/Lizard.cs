using UnityEngine;
using System.Collections;

public class Lizard : AttackerBase {

	void OnTriggerEnter2D (Collider2D collider) {
		GameObject collidedObject = collider.gameObject;
		
		if (collidedObject.GetComponent<Defender>()) {
			Attack();
		}
	}
}
