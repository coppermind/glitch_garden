using UnityEngine;
using System.Collections;

public class Fox : AttackerBase {

	void OnTriggerEnter2D (Collider2D collider) {
		GameObject collidedObject = collider.gameObject;
		
		if (collidedObject.GetComponent<Defender>()) {
			Animator animator = GetComponent<Animator>();
			if (collidedObject.GetComponent<Gravestone>()) {
				animator.SetTrigger("jump trigger");
			} else {
				animator.SetBool("isAttacking", true);
			}
		}
	}
	
	void Jump() {
		SetSpeed(2.4f);
	}
}
