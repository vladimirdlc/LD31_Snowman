using UnityEngine;
using System.Collections;

public class DestructorSwitch : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D other) {
		foreach (GameObject destroyable in GameObject.FindGameObjectsWithTag("Destroyable"))
			Destroy (destroyable);
	}

}
