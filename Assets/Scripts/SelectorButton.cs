using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SelectorButton : MonoBehaviour {
	
	public static GameObject selectedDefender;
	public GameObject defender;
	
	private SelectorButton[] buttons;
	private Text costLabel;
	
	void Start() {
		buttons = FindObjectsOfType<SelectorButton>();
		SetCostLabel();
	}
	
	void SetCostLabel() {
		costLabel = GetComponentInChildren<Text>();
		if (!costLabel) {
			Debug.LogWarning(name + " has no cost label!");
		}
		Defender defenderScript = defender.GetComponent<Defender>();
		costLabel.text = defenderScript.starsCost.ToString();
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
