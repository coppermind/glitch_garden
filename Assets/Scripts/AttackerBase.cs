using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Attacker))]
public class AttackerBase : MonoBehaviour {

	public float hitPoints;
	public float damagePoints;
	public float walkSpeed;
	public float jumpSpeed;
	
	protected Attacker attacker;
	protected Animator animator;
	
	private float currentSpeed = 0f;
	
	void Start() {
		attacker = GetComponentInParent<Attacker>();
		animator = GetComponent<Animator>();
	}
	
	void Update() {
		transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);
	}
	
	protected void Attack() {
		animator.SetBool("isAttacking", true);
	}
	
	protected void TriggerJump() {
		animator.SetTrigger("jump trigger");
	}
	
	protected void Jump() {
		SetSpeed(jumpSpeed);
	}
	
	protected void Walk() {
		SetSpeed(walkSpeed);
	}
	
	protected void Stand() {
		SetSpeed(0f);
	}

	void SetSpeed(float speed) {
		currentSpeed = speed;
	}

}
