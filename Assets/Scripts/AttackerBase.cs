using UnityEngine;
using System.Collections;

public class AttackerBase : MonoBehaviour {

	private Attacker attacker;
	
	void Start() {
		attacker = GetComponentInParent<Attacker>();
	}
	
	public void StopWalking() {
		attacker.SetSpeed(0f);
	}
	
	public void StartWalking() {
		attacker.SetSpeed(0.5f);
	}
	
	public void SetSpeed(float speed) {
		attacker.SetSpeed(speed);
	}

}
