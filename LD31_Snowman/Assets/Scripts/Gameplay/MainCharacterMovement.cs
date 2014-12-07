using UnityEngine;
using System.Collections;

public class MainCharacterMovement : MonoBehaviour {
	public float speedX = 4;
	public float speedY = 20;
	public bool canJump;

	void Start()
	{
		canJump = false;
	}


	// Update is called once per frame
	void Update () {
		float speedXTemp = speedX;

		if (Input.GetKey (KeyCode.LeftShift))
						speedX *= 1.5f;

		if (Input.GetKey (KeyCode.RightArrow)) {
			rigidbody2D.velocity = new Vector2(speedX, rigidbody2D.velocity.y);
			transform.localScale = new Vector3(1, 1, 1);
		}	
		if (Input.GetKey (KeyCode.LeftArrow)) {
			rigidbody2D.velocity = new Vector2(-speedX, rigidbody2D.velocity.y);
			transform.localScale = new Vector3(-1, 1, 1);
		}	

		if(canJump)
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, speedY);
			canJump = false;
		}

		if (rigidbody2D.velocity.x != 0) {
			GetComponent<Animator>().SetBool("isRunning", true);
		} //When there is not speed in X
		else GetComponent<Animator>().SetBool("isRunning", false); 

		speedX = speedXTemp;
	}
}
