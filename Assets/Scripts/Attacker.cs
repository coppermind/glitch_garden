using UnityEngine;
using System.Collections;

public class Attacker : MonoBehaviour {

	[Range (-2f, 1.5f)]
	public float currentSpeed;
	public float hitPoints;
	public float damagePoints;
	
	
	void Update () {
		transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);
	}
	
	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.gameObject.tag == "Defender") {
			Debug.Log("Collided (trigger) with a defender!");
			
		} else if (collider.gameObject.tag == "Projectile") {
			Debug.Log("Hit by a projectile");
		}
	}
	
	public void SetSpeed(float speed) {
		Debug.Log ("Setting speed to " + speed);
		currentSpeed = speed;
	}
	
}
