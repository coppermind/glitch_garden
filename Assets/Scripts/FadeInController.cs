using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeInController : MonoBehaviour {

	void Start () {
		Invoke("Suicide", 0.9f);
	}
	
	void Suicide() {
		Destroy(gameObject);
	}
}
