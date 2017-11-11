using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check : MonoBehaviour {

	public GameObject player;
	private Vector3 osz = new Vector3 (0f, -0.75f, 0f);
	void Start () {

	}
		
	void LateUpdate () {
		transform.position = player.transform.position+osz;

	}
}
