using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Health))]
public class Defender : MonoBehaviour {

	public bool isAttacking = false;

	void Update() {
		Animator animator = GetComponent<Animator>();
		animator.SetBool("isAttacking", isAttacking);
	}

}
