using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent (typeof(Text))]
public class StarDisplay : MonoBehaviour {

	private int starsInBank = 10;
	private Text text;
	
	void Start() {
		text = GetComponent<Text>();
		UpdateDisplay();
	}
	
	public int GetBankAmount() {
		return starsInBank;
	}
	
	public void AddStars(int amount) {
		starsInBank += amount;
		UpdateDisplay();
	}
	
	public void UseStars(int amount) {
		starsInBank -= amount;
		UpdateDisplay();
	}
	
	void UpdateDisplay() {
		text.text = starsInBank.ToString();
	}
}
