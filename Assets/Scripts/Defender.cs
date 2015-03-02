using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Health))]
public class Defender : MonoBehaviour {

	public int starsCost;

	private Animator animator;
	private StarDisplay starDisplay;
	
	void Start() {
		animator = GetComponent<Animator>();
		starDisplay = FindObjectOfType<StarDisplay>();
	}

	public void Attack() {
		animator.SetBool("isAttacking", true);
	}
	
	public void StopAttack() {
		animator.SetBool("isAttacking", false);
	}
	
	public void AddStars(int amount) {
		starDisplay.AddStars(amount);
	}
}
