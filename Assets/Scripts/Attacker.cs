using UnityEngine;
using System.Collections;

public class Attacker : MonoBehaviour {

	[Range (-2f, 1.5f)]
	public float walkSpeed;
	public float hitPoints;
	public float damagePoints;
	
	private bool isWalking = true;
	private bool isAttacking = false;

	void Start () {
	
	}
	
	void Update () {
		if (isWalking) {
			transform.Translate(Vector3.left * walkSpeed * Time.deltaTime);
		}
	}
	
	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.gameObject.tag == "Defender") {
			Debug.Log("Hit a defender");
			isWalking = false;
			isAttacking = true;
			//GameObject children = gameObject.GetComponentsInChildren<GameObject>() as GameObject;
			
		} else if (collider.gameObject.tag == "Projectile") {
			Debug.Log("Hit by a projectile");
		}
	}
}
