using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	public AudioClip[] levelMusic;
	
	private AudioSource audioSource;

	void Awake() {
		Debug.Log("Awake()");
		DontDestroyOnLoad(gameObject);
	}

	void OnLevelWasLoaded(int level) {
		Debug.Log("OnLevelWasLoaded()");
		PlayLevelMusic(level);
	}
	
	void PlayLevelMusic(int level) {
		audioSource = GetComponent<AudioSource>();
		if ( 0 < levelMusic.Length && levelMusic.Length-1 >= level && levelMusic[level] != null) {
			audioSource.clip = levelMusic[level];
			audioSource.loop = true;
			audioSource.Play();
			Debug.Log("audioSource.Play() done");
		} else {
			Debug.Log("audioSource not played!!!");
		}
	}
}
