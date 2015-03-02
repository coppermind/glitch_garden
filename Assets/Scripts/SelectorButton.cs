using UnityEngine;
using System.Collections;

public class SelectorButton : MonoBehaviour {
	
	public static GameObject selectedDefender;
	
	public GameObject defender;
	
	private SelectorButton[] buttons;
	
	void Start() {
		buttons = FindObjectsOfType<SelectorButton>();
	}
	
	void OnMouseDown() {
		DeselectButtons();
		GetComponent<SpriteRenderer>().color = Color.white;
		selectedDefender = defender;
	}
	
	void DeselectButtons() {
		foreach (SelectorButton button in buttons) {
			button.GetComponent<SpriteRenderer>().color = Color.black;
		}
	}
}
