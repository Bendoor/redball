using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
	Rigidbody2D ball;
	public float speed2=7f;
	public bool isGround=false;
	public Transform checkground;
	float groundRadius=0.2f;
	public LayerMask whatIsGround;
	public float PowerJump;
	void Start () 
	{
		ball = GetComponent<Rigidbody2D> ();
	}
	void FixedUpdate()
	{
		isGround = Physics2D.OverlapCircle (checkground.position, groundRadius, whatIsGround);
		if (!isGround)
			return;
	}
	void Update () 
	{
		float h = Input.GetAxis("Horizontal");
		if (h != 0) 
		{
			ball.AddForce (Vector2.right * speed2 * h);
		}
		jump ();
	
	}
	public void jump()
	{
		
		if (Input.GetKeyDown (KeyCode.Space) && isGround)
		{
			ball.AddForce (Vector2.up*PowerJump);
		}
	}


}
