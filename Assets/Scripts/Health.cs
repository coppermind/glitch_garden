using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public float health;
	
	public void Kill() {
		gameObject.transform.Translate(Vector3.right * 2f);
		Destroy(gameObject);
	}
	
	public void HitWith(float damage) {
		health -= damage;
		if (1 > health) {
			Kill();
		}
	}
}
