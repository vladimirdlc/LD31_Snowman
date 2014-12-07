using UnityEngine;
using System.Collections;

public class Generador : MonoBehaviour {
	public GameObject prefab;
	public float temporizador;
	public float minTiempoParaGenerar;
	public float maxTiempoParaGenerar;
	public float tiempoParaGenerarActual;

	// Use this for initialization
	void Start () {
		temporizador = 0;
		calcularTiempoParaGenerar();
	}
	
	// Update is called once per frame
	void Update () {
		if (temporizador > tiempoParaGenerarActual) {
			Instantiate(prefab);
			calcularTiempoParaGenerar();
			temporizador = 0;
		}


		temporizador += Time.deltaTime;
	}

	void calcularTiempoParaGenerar()
	{
		tiempoParaGenerarActual =
			Random.Range (minTiempoParaGenerar, maxTiempoParaGenerar);
	}
}







