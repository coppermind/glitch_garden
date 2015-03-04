using UnityEngine;
using System.Collections;

public class Gravestone : MonoBehaviour {

	private Animator animator;
	
	void Start() {
		animator = gameObject.GetComponent<Animator>();
	}

	void OnTriggerStay2D(Collider2D collider) {
		Attacker attacker = collider.gameObject.GetComponent<Attacker>();
		
		if (attacker) {
			animator.SetTrigger("underAttack trigger");
		}
	}
}
