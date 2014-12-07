using UnityEngine;
using System.Collections;

public class ColisionPersonaje : MonoBehaviour {
	public GameObject manejadorPuntaje;
	//public AudioSource sonido;

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.transform.tag == "Enemigo") {
			Debug.Log("recibe daño");
			manejadorPuntaje.GetComponent<ManejadorDePuntaje>().reportarPuntaje();
			GetComponent<Animator>().SetBool("estaMuerto", true);
			audio.Play();
			//sonido.PlayOneShot();
		}

		if (coll.transform.tag == "Bonus") {
			//aumentar el puntaje del juego
			//manejadorPuntaje.GetComponent<ManejadorDePuntaje>().agregarPuntaje();
		}


		Debug.Log ("colisiono contra: "+coll.transform.name);
	}

	void OnTriggerEnter2D(Collider2D other) {
		//if (other.name == "Piso") {
		Debug.Log ("Coaliciona");
		GetComponent<MovimientoPersonaje>().puedeSaltar = true;
		//}
	}



}

