using UnityEngine;
using System.Collections;

public class Attacker : MonoBehaviour {

	[Range (-2f, 1.5f)]
	public float currentSpeed;
	public float hitPoints;
	public float damagePoints;
	
//	private bool isWalking = true;
//	private bool isAttacking = false;
	private Animator animator;
	
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	void Update () {
		transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);
	}
	
	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.gameObject.tag == "Defender") {
			Debug.Log("Hit a defender");
//			isWalking = false;
//			isAttacking = true;
			//GameObject children = gameObject.GetComponentsInChildren<GameObject>() as GameObject;
			
		} else if (collider.gameObject.tag == "Projectile") {
			Debug.Log("Hit by a projectile");
		}
	}
	
	public void SetSpeed(float speed) {
		currentSpeed = speed;
	}
	
	public void AttackCurrentTarget(float damage) {
		Debug.Log("Attacking current target with " + damage.ToString() + " amount of damage");
	}
}
