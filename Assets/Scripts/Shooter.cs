using UnityEngine;
using System;
using System.Collections;

public class Shooter : MonoBehaviour {

	public GameObject projectile;
	public GameObject gun;
	
	private GameObject parent;
	private Defender defender;
	private AttackerSpawner myLaneSpawner;
	
	void Start() {
		defender = GameObject.FindObjectOfType<Defender>();
		SetMyLaneSpawner();
		FindOrSetupParent();
	}
	
	void Update() {
		if (IsAttackerInLane()) {
			defender.Attack();
		} else {
			defender.StopAttack();
		}
	}
	
	bool IsAttackerInLane() {
		if (0 < myLaneSpawner.transform.childCount && IsAttackerInFront()) {
			return true;
		}
		
		return false;
	}
	
	bool IsAttackerInFront() {
		foreach (Transform attacker in myLaneSpawner.transform) {
			if (transform.position.x < attacker.position.x) {
				return true;
			}
		}
		return false;
	}
	
	private void FindOrSetupParent() {
		parent = GameObject.Find("Projectiles");
		if (null == parent) {
			parent = new GameObject("Projectiles");
		}
	}
	
	private void SetMyLaneSpawner() {
		AttackerSpawner[] spawners = FindObjectsOfType<AttackerSpawner>();
		foreach (AttackerSpawner spawner in spawners) {
			if (spawner.transform.position.y == transform.position.y) {
				myLaneSpawner = spawner;
				break;
			}
		}
	}
	
	private void Fire() {
		GameObject newProjectile = Instantiate(projectile) as GameObject;
		newProjectile.transform.parent = parent.transform;
		newProjectile.transform.position = gun.transform.position;
	}

}
