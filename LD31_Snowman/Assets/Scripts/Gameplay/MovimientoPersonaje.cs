using UnityEngine;
using System.Collections;

public class MovimientoPersonaje : MonoBehaviour {
	public float velocidadX = 4;
	public float velocidadY = 20;
	public bool puedeSaltar;

	void Start()
	{
		puedeSaltar = false;
	}


	// Update is called once per frame
	void Update () {
		float velocidadXTemporal = velocidadX;

		if (Input.GetKey (KeyCode.LeftShift))
						velocidadX *= 1.5f;

		if (Input.GetKey (KeyCode.RightArrow)) {
			rigidbody2D.velocity = new Vector2(velocidadX, rigidbody2D.velocity.y);
			transform.localScale = new Vector3(1, 1, 1);
		}	
		if (Input.GetKey (KeyCode.LeftArrow)) {
			rigidbody2D.velocity = new Vector2(-velocidadX, rigidbody2D.velocity.y);
			transform.localScale = new Vector3(-1, 1, 1);
		}	

		if(puedeSaltar)
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, velocidadY);
			puedeSaltar = false;
		}

		if (rigidbody2D.velocity.x != 0) {
			GetComponent<Animator>().SetBool("estaCorriendo", true);
		} //Cuando no hay velocidad en x
		else GetComponent<Animator>().SetBool("estaCorriendo", false); 

		velocidadX = velocidadXTemporal;
	}
}
