using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controller : MonoBehaviour {
	private Rigidbody2D rb;
	private Vector3 mov;
	public bool alive;
	private bool first;
	public Text highscore;

	public float horizontal=2.0f;
	public float vertical= 5.0f;
	bool currentPlatformAndroid = false;

	void Awake(){
		#if UNITY_ANDROID
		currentPlatformAndroid= true;
		#else
		currentPlatformAndroid= false;
		#endif
	}
	// Use this for initialization
	void Start () {
	
		//if (currentPlatformAndroid == true)
			//Debug.Log ("Android");
		rb = GetComponent<Rigidbody2D> ();
		alive = true;
		Time.timeScale = 0;
		first = true;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (currentPlatformAndroid == true) 
		{
			//Debug.Log (Input.touchCount);
			if (Input.touchCount > 0 && first == true) 
			{
				Time.timeScale = 1;
				first = false;
			}
			if (Input.touchCount > 0) 
			{
				
				Touch myTouch = Input.GetTouch(0);
				float middle = Screen.width / 2;
				if (myTouch.phase == TouchPhase.Began && myTouch.position.x> middle) 
				{

					mov = new Vector3 (horizontal, vertical, 0);
					rb.velocity = mov;
				}
				else if (myTouch.phase == TouchPhase.Began && myTouch.position.x< middle) 
				{

					mov = new Vector3 (0.0f- horizontal, vertical, 0);
					rb.velocity = mov;
				}
			}
		} 

		else 
		{
			//rb.transform.Rotate( new Vector3(0,0,5));
			if (Input.anyKeyDown && first == true) {
				Time.timeScale = 1;
				first = false;
			}
			if (Input.GetKeyDown ("right")) {
				mov = new Vector3 (horizontal, vertical, 0);
				rb.velocity = mov;
			}
			if (Input.GetKeyDown ("left")) {
				mov = new Vector3 (0.0f - horizontal, vertical, 0);
				rb.velocity = mov;
			}
		}

		if (rb.transform.position.x <= -2.7f) 
		{
			
			rb.transform.position = new Vector3 (-2.7f, rb.position.y, 0f);
		}
		else if(rb.transform.position.x >=2.7f)
		{

			rb.transform.position = new Vector3 (2.7f, rb.position.y, 0f);
		}
		if(rb.transform.position.y>=0.0f)
		{
			
			rb.transform.position=new Vector3(rb.position.x,0.0f,0.0f);
		}
	}
	void OnCollisionEnter2D(Collision2D col)
	{
		highscore.text = "Highscore: " + ((int)PlayerPrefs.GetInt ("Highscore")).ToString();

		Time.timeScale = 0;
		alive = false;

	}

}
