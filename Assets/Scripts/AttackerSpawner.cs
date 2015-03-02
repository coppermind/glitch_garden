using UnityEngine;
using System.Collections;

public class AttackerSpawner : MonoBehaviour {

	public GameObject[] attackers;
	
	void Update () {
		foreach (GameObject thisAttacker in attackers) {
			if (isTimeToSpawn(thisAttacker)) {
				Spawn(thisAttacker);
			}
		}
	}
	

	bool isTimeToSpawn(GameObject attackerGameObject) {
		Attacker attackerComponent = attackerGameObject.GetComponent<Attacker>();
		
		float meanSpawnDelay = attackerComponent.seenEverySeconds;
		float spawnsPerSecond = 1 / meanSpawnDelay;
		float threshold = spawnsPerSecond * Time.deltaTime / 10;
		
		if (Time.deltaTime > meanSpawnDelay) {
			Debug.LogWarning("Swan rate capped by framerate");
		} else {
			if (Random.value < threshold) {
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
