using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
	private int currentScore = 0;
	public Text scoreLabel;
	public static ScoreManager instance;

	void Awake()
	{
		instance = this;
		DontDestroyOnLoad (gameObject.transform.root);
	}
	
	public void addScore()
	{
		currentScore++;
		refreshScoreGUI();
	}

	public void reportScore()
	{
		//Nuevo mejor puntaje
		if (PlayerPrefs.GetInt ("score") < currentScore) {
						PlayerPrefs.SetInt ("score", currentScore);
						Debug.Log("new record "+ currentScore);
				} else
						Debug.Log ("it is not best score");
	}

	public int getCurrentScore()
	{
		return currentScore;
	}

	private void refreshScoreGUI()
	{
		scoreLabel.text = string.Format ("Score: {0}", currentScore);
	}





}
