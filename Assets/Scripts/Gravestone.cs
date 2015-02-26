using UnityEngine;
using System.Collections;

public class Gravestone : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D collider) {
		Attacker attacker = collider.gameObject.GetComponent<Attacker>();
		
		if (attacker) {
			Animator animator = GetComponent<Animator>();
			animator.SetBool("isBeingAttacked", true);
		}
	}
	
	void OnTriggerExit2D(Collider2D collider) {
		Projectile projectile = collider.gameObject.GetComponent<Projectile>();
		
		if (!projectile) {
			Animator animator = GetComponent<Animator>();
			animator.SetBool("isBeingAttacked", false);
		}
	}
}
