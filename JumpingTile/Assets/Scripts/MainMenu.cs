using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

	public Text highscore;
	// Use this for initialization
	void Start () {
		highscore.text = "Highscore : " + ((int)PlayerPrefs.GetInt ("Highscore")).ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ToGame(){
		SceneManager.LoadScene ("Minigame");
	}
}
