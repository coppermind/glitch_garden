using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Animator))]
[RequireComponent (typeof (Health))]
public class AttackerBase : MonoBehaviour {

	public float damagePoints;
	public float walkSpeed;
	public float jumpSpeed;
	
	protected Animator animator;
	protected Health health;
	
	private float currentSpeed = 0f;
	private GameObject currentTarget;
	
	void Start() {
		animator = GetComponent<Animator>();
		health = GetComponent<Health>();
	}
	
	void Update() {
		transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);
		if (!currentTarget) {
			animator.SetBool("isAttacking", false);
		}
	}
	
	protected void Attack(GameObject target) {
		animator.SetBool("isAttacking", true);
		currentTarget = target;
	}
	
	protected void StrikeTarget() {
		if (currentTarget) {
			Health targetHealth = currentTarget.GetComponent<Health>();
			if (targetHealth) {
				targetHealth.HitWith(damagePoints);
			}
		}
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
