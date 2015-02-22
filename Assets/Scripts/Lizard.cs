using UnityEngine;
using System.Collections;

public class Lizard : AttackerBase {

	void OnTriggerEnter2D (Collider2D collider) {
		if (collider.gameObject.tag == "Defender") {
			Animator animator = GetComponent<Animator>();
			animator.SetBool("isAttacking", true);
		}
	}
	
}
