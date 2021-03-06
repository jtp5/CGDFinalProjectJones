﻿using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {
	
	public float jumpSpeed = 200f;
	public float forwardSpeed = 0;
	public float myScaleX = -0.1f;
	public float myScaleX2= 0.1f;
	public float myScaleY = 0.1f;
	public float myScaleZ = 1f;
	private Rigidbody2D body2d;
	private InputState inputState;
	
	void Awake(){
		body2d = GetComponent<Rigidbody2D> ();
		inputState = GetComponent<InputState> ();
		transform.localScale = new Vector2(myScaleX2, myScaleY);
	}


	
	// Update is called once per frame
	void Update () {
		
		if (inputState.standing) {





			if(inputState.actionButton && inputState.standing){
				body2d.velocity = new Vector2(transform.position.x < 0 ? forwardSpeed : 0, jumpSpeed);
			
			
				if (inputState.left)
				{
					body2d.velocity = new Vector2(-50, 10);
					transform.localScale = new Vector2(myScaleX2, myScaleY);



				}
				if (inputState.right)
				{
					body2d.velocity = new Vector2(50, 10);
					transform.localScale = new Vector2(myScaleX, myScaleY);
				}
			
			
			}






			if (inputState.left)
			{
				body2d.velocity = new Vector2(-50, 10);
				transform.localScale = new Vector2(myScaleX2, myScaleY);

				if(inputState.actionButton && inputState.standing){
					body2d.velocity = new Vector2(transform.position.x < 0 ? forwardSpeed : 0, jumpSpeed);

				
				}


			}


			if (inputState.right)
			{
				body2d.velocity = new Vector2(50, 10);
				transform.localScale = new Vector2(myScaleX, myScaleY);
			}

			Debug.Log(inputState.standing);





		}
		



		

	}

	public void MoveToStart()
	{
		body2d.position = new Vector2 (15f,-46.5f);
	}








}

