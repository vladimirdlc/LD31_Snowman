using UnityEngine;
using System.Collections;

public class EnemyBehavior : MonoBehaviour {

	public float speedX = 4;
	public float speedY = 20;
	public bool isFrozen;
	public bool direction = false;
	private bool isStill;

	// Use this for initialization
	void Start () {
		isFrozen = false;
	}
	
	// Update is called once per frame
	void Update () {
		//float speedXTemp = speedX;

		if (isStill) return;

		if (direction) {
				rigidbody2D.velocity = new Vector2(-speedX, rigidbody2D.velocity.y);
				transform.localScale = new Vector3(-1, 1, 1);
			}
		else {
				rigidbody2D.velocity = new Vector2(speedX, rigidbody2D.velocity.y);
				transform.localScale = new Vector3(1, 1, 1);
			}
				
	}

	void OnTriggerEnter2D(Collider2D other) {
		// Change directions if collides againts anything but player
		if (other.tag == "Player") isStill = true;
		else direction = !direction;
	}

	void OnTriggerExit2D(Collider2D other) {
		isStill = false;
	}
}
