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
    private int healsPoint = 3;
    private bool immortal = false;
    private float immortalTime = 0;

	void Start () 
	{
		ball = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate()
	{
		isGround = Physics2D.OverlapCircle (checkground.position, groundRadius, whatIsGround);
		if (!isGround)
			return;
        if (immortal == true && immortalTime >= 2)
        {
            immortal = false;
            immortalTime = 0;
        }      
	}



    void Update()
    {
        if (healsPoint <= 0)
        {
            //тут будет код смерти
        }
        if (immortal == true)
            immortalTime += Time.deltaTime;

        float h = Input.GetAxis("Horizontal");
        if (h != 0)
        {
            ball.AddForce(Vector2.right * speed2 * h);
        }
        jump();

    }

    private void LateUpdate()
    {
      //тут пока ничего  
    }

    public void jump()
	{
		
		if (Input.GetKeyDown (KeyCode.Space) && isGround)
		{
			ball.AddForce (Vector2.up * PowerJump);
		}
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
       if ( ((other.tag == "big_thorns") || (other.tag == "thorns")) && immortal == false) // Снятие одной единицы жизнии при вхождении в триггер шипов(маллых и больших) и установка бессмертия
        {
            healsPoint--;
            if (healsPoint > 0)
            {
                immortal = true;
                ball.AddForce(Vector2.up * (PowerJump/2));
            }
        }
    }
}
