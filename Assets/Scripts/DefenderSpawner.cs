using UnityEngine;
using System;
using System.Collections;

public class DefenderSpawner : MonoBehaviour {

	private GameObject defenderParent;
	
	void Start () {
		FindOrSetupParent();
	}
	
	void FindOrSetupParent() {
		defenderParent = GameObject.Find("Defenders");
		if (null == defenderParent) {
			defenderParent = new GameObject("Defenders");
		}
	}
	
	void OnMouseDown() {
		if (null != SelectorButton.selectedDefender) {
			SpawnDefender();
		}
	}
	
	void SpawnDefender() {
		Vector2 currentPosition = GetWorldPoint();
		GameObject newDefender = Instantiate(SelectorButton.selectedDefender) as GameObject;
		newDefender.transform.parent = defenderParent.transform;
		newDefender.transform.position = currentPosition;
	}
	
	Vector2 GetWorldPoint() {
		float mouseX = Input.mousePosition.x;
		float mouseY = Input.mousePosition.y;
		float distanceToCamera = 10f;
		Vector3 wp = GetCamera().ScreenToWorldPoint(new Vector3(mouseX, mouseY, distanceToCamera));
		
		return SnapToGrid(wp);
	}
	
	Vector2 SnapToGrid(Vector3 rawPosition) {
		float x = Mathf.RoundToInt(rawPosition.x);
		float y = Mathf.RoundToInt(rawPosition.y);
		
		return new Vector2(x, y);
	}
	
	Camera GetCamera() {
		GameObject gameCamera = GameObject.Find("Game Camera");
		return gameCamera.GetComponent<Camera>();
	}
}
