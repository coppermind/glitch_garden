using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OptionsController : MonoBehaviour {

	public Slider volumeSlider;
	public Slider difficultySlider;
	
	private MusicManager musicManager;

	void Start () {
		musicManager = GameObject.FindObjectOfType<MusicManager>();
		
		volumeSlider.value = PlayerPrefsManager.GetMasterVolume();
		difficultySlider.value = PlayerPrefsManager.GetDifficulty();
	}
	
	public void SaveVolume() {
		PlayerPrefsManager.SetMasterVolume(volumeSlider.value);
		musicManager.SetVolume(volumeSlider.value);
	}
	
	public void SaveDifficulty() {
		PlayerPrefsManager.SetDifficulty(difficultySlider.value);
	}
	
	public void SetDefaults() {
		volumeSlider.value = 0.80f;
		difficultySlider.value = 2f;
		
		SaveVolume();
		SaveDifficulty();
	}

}
