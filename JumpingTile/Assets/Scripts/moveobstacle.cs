using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveobstacle : MonoBehaviour {

	public GameObject player;
	private float velocity;
	private float posi;
	public int score=0;
	public bool scoreUpdate;
	// Use this for initialization
	void Start () {
		scoreUpdate = false;
		player= GameObject.FindGameObjectWithTag("Player");
		velocity= player.GetComponent<Rigidbody2D> ().velocity.y;
		posi = player.GetComponent<Rigidbody2D> ().transform.position.y;
	}
	
	// Update is called once per frame
	void Update ()
	{
		velocity = player.GetComponent<Rigidbody2D> ().velocity.y;
		posi = player.GetComponent<Rigidbody2D> ().transform.position.y;
	
		if (posi >= 0.0f)
			transform.Translate (new Vector3 (0.0f, 0.0f - velocity, 0.0f) * Time.deltaTime);



	}
}

