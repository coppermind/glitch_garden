using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	public AudioClip[] levelMusic;
	
	private AudioSource audioSource;

	void Awake() {
		DontDestroyOnLoad(gameObject);
	}
	
	void Start() {
		audioSource = GetComponent<AudioSource>();
		audioSource.volume = PlayerPrefsManager.GetMasterVolume();
	}

	void OnLevelWasLoaded(int level) {
		PlayLevelMusic(level);
	}
	
	void PlayLevelMusic(int level) {
		if ( 0 < levelMusic.Length && levelMusic.Length-1 >= level && levelMusic[level] != null) {
			audioSource.clip = levelMusic[level];
			audioSource.loop = true;
			audioSource.Play();
		}
	}
	
	public void SetVolume(float volumeLevel) {
		audioSource.volume = volumeLevel;
	}
}
