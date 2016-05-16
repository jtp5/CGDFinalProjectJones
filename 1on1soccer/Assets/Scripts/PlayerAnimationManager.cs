using UnityEngine;
using System.Collections;

public class PlayerAnimationManager : MonoBehaviour {

	private Animator animator;
	private bool running;
	// Use this for initialization
	void Awake () {
		var running = false;
		animator = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
	


		if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.RightArrow)) {
			running = true;
		}
		else 
		{
			running = false;
		}

		animator.SetBool ("running", running);



	}




}
