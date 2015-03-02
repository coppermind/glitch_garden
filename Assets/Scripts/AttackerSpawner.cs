using UnityEngine;
using System;
using System.Collections;

public class AttackerSpawner : MonoBehaviour {

	public GameObject[] attackers;
	
	private float[] lastSpawnTime;
	private int currentAttacker;
	
	void Start() {
		lastSpawnTime = new float[attackers.Length];
	}

	void Update () {
		Debug.Log("Spawning: " + UnityEngine.Random.Range(0, attackers.Length * 100) % attackers.Length);
		Debug.Log("Time Array: " + lastSpawnTime.Length);
		Debug.Log("First: " + lastSpawnTime[0]);
		foreach (GameObject thisAttacker in attackers) {
			if (isTimeToSpawn(thisAttacker)) {
				Spawn(thisAttacker);
			}
		}
	}
	
	int GetCurrentAttacker() {
		currentAttacker = UnityEngine.Random.Range(0, attackers.Length * 100) % attackers.Length;
		return currentAttacker;
	}
	
	bool isTimeToSpawn(GameObject attacker) {
		if (0 == lastSpawnTime[currentAttacker]) {
			lastSpawnTime[currentAttacker] = Time.time;
			return true;
		} else {
			Attacker attackerComponent = attackers[currentAttacker].GetComponent<Attacker>();
			
			float elapsedTime = Time.time - lastSpawnTime[currentAttacker];
			if (attackerComponent.seenEverySeconds < elapsedTime) {
				lastSpawnTime[currentAttacker] = Time.time;
				return true;
			}
		}
		return false;
	}
	
	void Spawn(GameObject attacker) {
		GameObject newAttacker = Instantiate(attacker) as GameObject;
		newAttacker.transform.parent = transform;
		newAttacker.transform.position = transform.position;
	}
}
