using UnityEngine;
using System;
using System.Collections;

public class Shooter : MonoBehaviour {

	public GameObject projectile;
	public GameObject gun;
	
	private GameObject parent;
	
	void Start() {
		FindOrSetupParent();
	}
	
	private void FindOrSetupParent() {
		parent = GameObject.Find("Projectiles");
		if (null == parent) {
			parent = new GameObject("Projectiles");
		}
	}
	
	private void Fire() {
		GameObject newProjectile = Instantiate(projectile) as GameObject;
		newProjectile.transform.parent = parent.transform;
		newProjectile.transform.position = gun.transform.position;
	}

}
