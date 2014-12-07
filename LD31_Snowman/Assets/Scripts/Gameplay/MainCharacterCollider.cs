using UnityEngine;
using System.Collections;

public class MainCharacterCollider : MonoBehaviour {
	public GameObject scoreManager;
	//public AudioSource audio;

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.transform.tag == "Enemy") {
			//Debug.Log("is Damaged");
			scoreManager.GetComponent<ScoreManager>().reportScore();
			GetComponent<Animator>().SetBool("is Dead", true);
			audio.Play();
			//audio.PlayOneShot();
		}

		if (coll.transform.tag == "Bonus") {
			//increases game score
			//manejadorPuntaje.GetComponent<ScoreManager>().addScore();
		}


		//Debug.Log ("collided againts : "+coll.transform.name);
	}

	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log ("Collition");
		GetComponent<MainCharacterMovement>().canJump = true;
	}

	void OnTriggerExit2D(Collider2D other) {
		Debug.Log ("Not Collition");
		GetComponent<MainCharacterMovement>().canJump = false;
	}

	void OnTriggerStay2D(Collider2D other) {
		GetComponent<MainCharacterMovement>().canJump = true;
	}


}

