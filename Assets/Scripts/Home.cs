using UnityEngine;
using System.Collections;

public class Home : MonoBehaviour {

	private LevelManager levelManager;

	void Start() {
		levelManager = GameObject.FindObjectOfType<LevelManager>();
	}

	void OnTriggerEnter2D(Collider2D collider) {
		levelManager.LoadLevel("03b Lose");
	}

}
