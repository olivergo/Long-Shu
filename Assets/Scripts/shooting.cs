﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour {
	public float speed;
	Rigidbody2D rb2d ;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		rb2d.AddForce (Vector2.right * speed);
	}
}
