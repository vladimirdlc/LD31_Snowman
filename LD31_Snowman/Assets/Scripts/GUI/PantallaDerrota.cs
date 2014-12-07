using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PantallaDerrota : MonoBehaviour {
	public Text textPuntajeValor;
		
	void Start()
	{
		actualizarPuntaje(textPuntajeValor);
	}

	public void actualizarPuntaje(Text etiqueta)
	{
		int puntajeActual =
			GameObject.Find ("ManejadorDePuntaje")
				.GetComponent<ManejadorDePuntaje> ()
				.getPuntajeActual ();

		etiqueta.text = puntajeActual.ToString ();
	}

	public void actualizaMejorPuntaje(Text etiqueta)
	{
	}
}
