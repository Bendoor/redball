using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
	Rigidbody2D ball;
	public float speed1=5f;
	public float speed2=7f;


	// Use this for initialization
	void Start () {
		ball = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (Input.GetKeyDown (KeyCode.Space))
		{
			ball.AddForce (Vector2.up * speed1, ForceMode2D.Impulse);
		}

		float h = Input.GetAxis("Horizontal");
		if (h != 0) 
		{
			ball.AddForce (Vector2.right * speed2 * h);
		}
	}
}
