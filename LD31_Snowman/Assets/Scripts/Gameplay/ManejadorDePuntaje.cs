using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ManejadorDePuntaje : MonoBehaviour {
	private int puntajeActual = 0;
	public Text etiquetaPuntaje;
	public static ManejadorDePuntaje Instancia;

	void Awake()
	{
		Instancia = this;
		DontDestroyOnLoad (gameObject.transform.root);
	}
	
	public void agregarPuntaje()
	{
		puntajeActual++;
		actualizarPuntajeGUI();
	}

	public void reportarPuntaje()
	{
		//Nuevo mejor puntaje
		if (PlayerPrefs.GetInt ("puntaje") < puntajeActual) {
						PlayerPrefs.SetInt ("puntaje", puntajeActual);
						Debug.Log("nuevo record "+ puntajeActual);
				} else
						Debug.Log ("no es mejor puntaje");
	}

	public int getPuntajeActual()
	{
		return puntajeActual;
	}

	private void actualizarPuntajeGUI()
	{
		etiquetaPuntaje.text = string.Format ("Puntaje: {0}", puntajeActual);
	}





}
