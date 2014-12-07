using UnityEngine;
using System.Collections;

public class Meta : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Bonus") {
						ManejadorDePuntaje.Instancia.agregarPuntaje ();
						Destroy (other.gameObject);
		}
	}
}
