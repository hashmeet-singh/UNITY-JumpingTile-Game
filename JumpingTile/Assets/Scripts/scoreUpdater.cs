using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scoreUpdater : MonoBehaviour {

	public int currentScore;
	public Text text;
	public spawner scorecount;
	// Use this for initialization

	void Start () {
		text = gameObject.GetComponent<Text> ();
		text.text = "Score: 0";
		scorecount = GameObject.FindGameObjectWithTag ("Respawn").GetComponent<spawner> ();
	}

	
	// Update is called once per frame
	void Update () {
		scorecount = GameObject.FindGameObjectWithTag ("Respawn").GetComponent<spawner> ();
		if (scorecount.score == 0) 
		{
			currentScore = scorecount.score;
			text.text = "Score: " + scorecount.score.ToString ();
		
		}
		else {
			currentScore = scorecount.score - 1;
			text.text = "Score: " + currentScore.ToString ();	
			
		}
		if (currentScore > PlayerPrefs.GetInt ("Highscore")) 
		{
			PlayerPrefs.SetInt ("Highscore", currentScore);
			Debug.Log (PlayerPrefs.GetInt ("Highscore"));
		}

	}
}
