using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fon_control : MonoBehaviour {
	public GameObject player;
	public Vector3 osz=new Vector3(0.1f,0.1f,3f);
	public Vector3 osz1;
	public Vector3 osz2;
	void Start () {
		osz1 = transform.position;
	}

	void Update () {
		osz2 =Vector3.Scale(player.transform.position, osz);
		transform.position = osz1 + osz2;

	}
}
