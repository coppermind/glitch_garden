using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Animator))]
[RequireComponent (typeof (Health))]
public class AttackerBase : MonoBehaviour {

	public float damage;
	public float walkSpeed;
	public float jumpSpeed;
	
	protected Animator animator;
	protected Health health;
	
	private float currentSpeed = 0f;
	private GameObject currentTarget;
	
	private GameObject defenderParent;
	
	void Start() {
		animator = GetComponent<Animator>();
		health = GetComponent<Health>();
		FindOrSetupParent();
	}
	
	void FindOrSetupParent() {
		defenderParent = GameObject.Find("Defenders");
		if (null == defenderParent) {
			defenderParent = new GameObject("Defenders");
		}
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
				targetHealth.HitWith(damage);
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
