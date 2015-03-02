using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Health))]
public class Defender : MonoBehaviour {

	public bool isAttacking = false;
	
	private Animator animator;

	void Update() {
		animator = GetComponent<Animator>();
	}

	public void Attack() {
		animator.SetBool("isAttacking", true);
	}
	
	public void StopAttack() {
		animator.SetBool("isAttacking", true);
	}
}
