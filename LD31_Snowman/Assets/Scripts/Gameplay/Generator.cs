using UnityEngine;
using System.Collections;

public class Generator : MonoBehaviour {
	public GameObject prefab;
	public float timer;
	public float minTimeToGenerate;
	public float maxTimeToGenerate;
	public float timeToGenerateCurrent;

	// Use this for initialization
	void Start () {
		timer = 0;
		calculateTimeToGenerate();
	}
	
	// Update is called once per frame
	void Update () {
		if (timer > timeToGenerateCurrent) {
			Instantiate(prefab);
			calculateTimeToGenerate();
			timer = 0;
		}


		timer += Time.deltaTime;
	}

	void calculateTimeToGenerate()
	{
		timeToGenerateCurrent =
			Random.Range (minTimeToGenerate, maxTimeToGenerate);
	}
}







