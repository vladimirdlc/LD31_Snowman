using UnityEngine;
using System.Collections;

public class EnemyBehavior : MonoBehaviour {

	public float speedX = 4;
	public float speedY = 20;
	public bool isFrozen;
	public bool goLeft = false;
	public float frozenTime = 10.0f;
	private bool isStill;

	// Use this for initialization
	void Start () {
		isFrozen = false;
	}
	
	// Update is called once per frame
	void Update () {
		//float speedXTemp = speedX;

		if (isStill || isFrozen) return;

		if (goLeft) {
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
		switch (other.tag) {
		case "Player":
			isStill = true;
			break;
		case "Hook": 
			if (!isFrozen) {
				isFrozen = true;
				Invoke("unfrozen",frozenTime);
			}

			break;
		default: goLeft = !goLeft;
			break;
		}
	}

	void OnTriggerExit2D(Collider2D other) {

		isStill = false;
		if (other.tag == "Player") goLeft = !goLeft;
	}

	void unfrozen() {
		isFrozen = false;
	}
	
}
