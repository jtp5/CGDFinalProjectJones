﻿using UnityEngine;
using System.Collections;

public class ScoreTeleport : MonoBehaviour {

	public int scoreValue = 1;
	private Jump GreenJump;

	public GameObject player1;
	public GameObject player2;

	private AudioSource source;
	public AudioClip goal;

	void Awake(){
		source = GetComponent<AudioSource> ();
		GreenJump = GetComponent<Jump> ();


	}

	void OnTriggerEnter2D (Collider2D coll){
		if (coll.gameObject.tag.Equals("Ball")) {
			Rigidbody2D ball = coll.GetComponent<Rigidbody2D>();
			ball.velocity = new Vector2 (0,0);
			ball.position = new Vector2 (0,28);
			player1.transform.position = new Vector3(15f, -46.5f, -6);
			player2.transform.position = new Vector3(-13.5f, -46.5f, -6);
			player1.transform.localScale = new Vector2 (.1f,.1f);
			player2.transform.localScale = new Vector2 (.1f,.1f);
			ScoreManager.score += scoreValue;
			source.PlayOneShot(goal, .25f);
		}


	

	}
	                     




	

}
