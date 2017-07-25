using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class uimanager : MonoBehaviour {

	GameObject[] finishedobj;
	controller playercontroller;
	// Use this for initialization
	void Start () {
		finishedobj = GameObject.FindGameObjectsWithTag ("GameOver");
		hideFinished ();

		if (Application.loadedLevelName == "Minigame") 
		{
			playercontroller = GameObject.FindGameObjectWithTag ("Player").GetComponent<controller> ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeScale == 0 && playercontroller.alive == false) 
		{
			showFinished ();
		}
	}
	public void showFinished()
	{
		foreach(GameObject g in finishedobj){
			g.SetActive (true);
		}
	}

	public void hideFinished()
	{
		foreach(GameObject g in finishedobj){
			g.SetActive (false);
		}
	}

	public void Reload()
	{
		Application.LoadLevel (Application.loadedLevel);
	}
}

