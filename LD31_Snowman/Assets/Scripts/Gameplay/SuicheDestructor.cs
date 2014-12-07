using UnityEngine;
using System.Collections;

public class SuicheDestructor : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D other) {
		foreach (GameObject destruible in GameObject.FindGameObjectsWithTag("Destruibles"))
						Destroy (destruible);
	}

}
