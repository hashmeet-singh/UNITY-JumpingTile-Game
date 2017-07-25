using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shop : MonoBehaviour {

	public GameObject shopButtoncontainer;
	public GameObject shopButtonPrefab;
	// Use this for initialization
	void Start () {
	
		Sprite[] playerObj = Resources.LoadAll<Sprite> ("Player");
		Debug.Log ("Sprite Length:" + playerObj.Length);
		foreach (Sprite s in playerObj) {
			GameObject container = Instantiate (shopButtonPrefab) as GameObject; 
			GameObject img = container.transform.GetChild (0).gameObject;
			img.GetComponent<Image> ().sprite = s;

			container.transform.SetParent (shopButtoncontainer.transform, false);
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
