﻿using UnityEngine;

public class PlayerScript : MonoBehaviour
{

	public Vector2 speed = new Vector2(50,50);
	private Vector2 movement;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var inputX = Input.GetAxis("Horizontal");
		var inputY = Input.GetAxis("Vertical");

		movement = new Vector2(
			speed.x * inputX,
			speed.y * inputY);
	}

	void FixedUpdate()
	{
		rigidbody2D.velocity = movement;
	}
}
