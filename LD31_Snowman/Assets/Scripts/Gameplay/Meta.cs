using UnityEngine;
using System.Collections;

public class Meta : MonoBehaviour {
    public string sceneToLoad;

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player")
        {
            if(MainCharacterMovement.hasKey == true)
                Application.LoadLevel(sceneToLoad);
        }
	}
}
