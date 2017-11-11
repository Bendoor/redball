using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_control : MonoBehaviour {
	public GameObject player;
	private Vector3 offset=new Vector3(-1f,-3.5f,0f);
	private Vector3 osz=new Vector3(1f,3.4f,-5);
	void Start () {

	}
	void LateUpdate () {
		if ((player.transform.position.x > offset.x) && (player.transform.position.y>offset.y) )
		{
			transform.position = player.transform.position + osz;
		}
	}
}
