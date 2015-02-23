using UnityEngine;
using System.Collections;

//[RequireComponent (typeof (Attacker))]
[RequireComponent (typeof (Animator))]
public class AttackerBase : MonoBehaviour {

	public float hitPoints;
	public float damagePoints;
	public float walkSpeed;
	public float jumpSpeed;
	
	//protected Attacker attacker;
	protected Animator animator;
	
	private float currentSpeed = 0f;
	private GameObject currentTarget;
	
	void Start() {
		//attacker = GetComponentInParent<Attacker>();
		animator = GetComponent<Animator>();
	}
	
	void Update() {
		transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);
	}
	
	protected void Attack(GameObject target) {
		animator.SetBool("isAttacking", true);
		currentTarget = target;
	}
	
	protected void StrikeTarget() {
		Debug.Log("Striking current target: " + currentTarget);
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
