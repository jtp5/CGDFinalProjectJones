using UnityEngine;
using System.Collections;

public class redAnimation : MonoBehaviour {
	
	private Animator animator;
	private bool Running;
	// Use this for initialization
	void Awake () {
		var Running = false;
		animator = GetComponent<Animator> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.D)) {
			Running = true;
		}
		else 
		{
			Running = false;
		}
		
		animator.SetBool ("Running", Running);
		
		
		
	}
}
