using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Animator))]
[RequireComponent (typeof (Health))]
public class Attacker : MonoBehaviour {

	[Tooltip ("Average number of seconds between spawn")]
	public float seenEverySeconds;
	public float damage;
	public float walkSpeed;
	public float jumpSpeed;
	
	protected Animator animator;
	protected Health health;
	
	private GameObject attackerParent;
	private float currentSpeed = 0f;
	private GameObject currentTarget;
	
	
	void Start() {
		animator = GetComponent<Animator>();
		health = GetComponent<Health>();
	}
	
	void Update () {
		transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);
		if (!currentTarget) {
			animator.SetBool("isAttacking", false);
		}
	}
	
	public void Attack(GameObject target) {
		animator.SetBool("isAttacking", true);
		currentTarget = target;
	}
	
	public void SetSpeed(float speed) {
		currentSpeed = speed;
	}
	
	public void TriggerJump() {
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
	
	protected void StrikeTarget() {
		if (currentTarget) {
			Health targetHealth = currentTarget.GetComponent<Health>();
			if (targetHealth) {
				targetHealth.HitWith(damage);
			}
		}
	}
}
