using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public float autoLoadNextLevelAfterTime;
	public bool autoLoadNextLevel = false;
	
	void Start() {
		if (autoLoadNextLevel) {
			Invoke ("LoadNextLevel", autoLoadNextLevelAfterTime);
		}
	}

	public void LoadLevel(string name){
		Application.LoadLevel(name);
	}
	
	public void LoadNextLevel() {
		Application.LoadLevel(Application.loadedLevel + 1);
	}

	public void QuitRequest(){
		Application.Quit();
	}

}
