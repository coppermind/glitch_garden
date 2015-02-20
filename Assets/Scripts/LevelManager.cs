using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public float autoLoadNextLevelAfterTime;
	
	void Start() {
		if (0 < autoLoadNextLevelAfterTime) {
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
