using UnityEngine;
using System.Collections;

public class Fox : AttackerBase {

	void OnTriggerEnter2D (Collider2D collider) {
		GameObject collidedObject = collider.gameObject;
		
		if (collidedObject.GetComponent<Defender>()) {
			if (collidedObject.GetComponent<Gravestone>()) {
				TriggerJump();
			} else {
				Attack(collidedObject);
			}
		}
	}

}
