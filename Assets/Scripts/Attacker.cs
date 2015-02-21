using UnityEngine;
using System.Collections;

public class Attacker : MonoBehaviour {

	[Range (-2f, 1.5f)]
	public float walkSpeed;

	void Start () {
	
	}
	
	void Update () {
		transform.Translate(Vector3.left * walkSpeed * Time.deltaTime);
	}
}
