using UnityEngine;
using System.Collections;

public class StartScreen : MonoBehaviour {

	private MusicManager musicManager;
	
	void Start () {
		musicManager = FindObjectOfType<MusicManager>();
		if (musicManager) {
			musicManager.SetVolume( PlayerPrefsManager.GetMasterVolume() );
		} else {
			Debug.LogWarning("Music manager not found in start scene, cannot set master volume.");
		}
	}
	
}
