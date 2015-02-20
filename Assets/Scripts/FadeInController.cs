using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeInController : MonoBehaviour {

	void Start () {
		Debug.Log ("A: " + GetComponent<Image>().color.a);
		Invoke("Suicide", 0.9f);
	}
	
	void Suicide() {
		Debug.Log("Killing self now");
		Destroy(gameObject);
	}
}
