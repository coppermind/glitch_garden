using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelTimer : MonoBehaviour {

	public float levelSeconds = 100;

	private Slider slider;
	private LevelManager levelManager;
	private AudioSource audioSource;
	private bool isEndOfLevel = false;
	private GameObject youWin;
	
	void Start () {
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		audioSource = GetComponent<AudioSource>();
		slider = GetComponent<Slider>();
		FindYouWin();
	}
	
	void Update () {
		if (!isEndOfLevel) {
			slider.value = Time.timeSinceLevelLoad / levelSeconds;
			if (Time.timeSinceLevelLoad > levelSeconds) {
				PlayerWins();
			}
		}
	}

	void FindYouWin() {
		youWin = GameObject.Find ("You Win");
		if (!youWin) {
			Debug.Log ("You Win text missing.");
		} else {
			youWin.SetActive(false);
		}
	}
	
	void PlayerWins() {
		KillAllAttackers();
		FlashWin();
		audioSource.Play();
		Invoke("LoadNextLevel", audioSource.clip.length);
		isEndOfLevel = true;
	}
	
	void FlashWin() {
		youWin.SetActive(true);
	}
	
	void KillAllAttackers() {
		AttackerSpawner[] spawners = FindObjectsOfType<AttackerSpawner>();
		foreach (AttackerSpawner spawner in spawners) {
			spawner.GameIsOver();
		}
	}
	
	void LoadNextLevel() {
		levelManager.LoadNextLevel();
	}
}
