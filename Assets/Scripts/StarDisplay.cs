using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent (typeof(Text))]
public class StarDisplay : MonoBehaviour {

	public enum Status {SUCCESS, FAILURE};

	private int starsInBank = 100;
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
	
	public Status UseStars(int amount) {
		if (amount < starsInBank) {
			starsInBank -= amount;
			UpdateDisplay();
			return Status.SUCCESS;
		}
		return Status.FAILURE;
	}
	
	void UpdateDisplay() {
		text.text = starsInBank.ToString();
	}
}
