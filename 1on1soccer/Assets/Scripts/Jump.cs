﻿using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {
	
	public float jumpSpeed = 200f;
	public float forwardSpeed = 0;
	
	private Rigidbody2D body2d;
	private InputState inputState;
	
	void Awake(){
		body2d = GetComponent<Rigidbody2D> ();
		inputState = GetComponent<InputState> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (inputState.standing) {
			if(inputState.actionButton){
				body2d.velocity = new Vector2(transform.position.x < 0 ? forwardSpeed : 0, jumpSpeed);
			}
		}
		

		
		if (inputState.left)
		{
			body2d.velocity = new Vector2(-50, 0);
		}
		if (inputState.right)
		{
			body2d.velocity = new Vector2(50, 0);
		}
	}
}
