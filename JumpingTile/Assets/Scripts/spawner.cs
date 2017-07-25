using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {
	public GameObject[] obstacles;
	private GameObject clone;
	public int score;

	// Use this for initialization
	void Start () {
		score = 0;
		clone = (GameObject)Instantiate (obstacles[Random.Range(0,obstacles.Length)], transform.position, transform.rotation);
		clone.name = "Obst";

	}
	
	// Update is called once per frame
	void Update () {
		
		GameObject ob = GameObject.Find ("Obst");


		if (clone.transform.position.y<=6.2f && clone.GetComponent<moveobstacle>().scoreUpdate==false) 
		{
			score++;
			//Debug.Log ("Score:"+score+ "Psition:"+ ob.transform.position.y);
			clone.GetComponent<moveobstacle> ().scoreUpdate = true;
		}
		if (clone.transform.position.y<=5.0f) 
		{
			clone = (GameObject)Instantiate (obstacles[Random.Range(0,obstacles.Length)], transform.position, transform.rotation);
			clone.name = "Obst";



		}

		if (ob.transform.position.y < -6.0f)
			Destroy (ob);
			

			
	}

}
