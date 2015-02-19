using UnityEngine;
using System.Collections;

public class SplashController : MonoBehaviour {

	void Start () {
		Invoke ("LoadStartScreen", 4f);
	}
	
	void LoadStartScreen() {
		Application.LoadLevel(1);
	}
	
}
