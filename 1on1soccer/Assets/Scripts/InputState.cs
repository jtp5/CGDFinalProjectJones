using UnityEngine;
using System.Collections;

public class InputState : MonoBehaviour {
	
	public bool actionButton;
	public bool actionButton2;
	public bool left;
	public bool left2;
	public bool right;
	public bool right2;
	public float absVelX = 0f;
	public float absVelY = 0f;
	public bool standing;
	public float standingThreshold = 1;
	
	private Rigidbody2D body2d;
	
	void Awake(){
		body2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		actionButton = Input.GetKeyDown(KeyCode.UpArrow);
		actionButton2 = Input.GetKeyDown (KeyCode.W);
		right = Input.GetKey(KeyCode.RightArrow);
		right2 = Input.GetKey (KeyCode.D);
		left = Input.GetKey(KeyCode.LeftArrow);
		left2 = Input.GetKey (KeyCode.A);
	}
	
	void FixedUpdate(){
		absVelX = System.Math.Abs (body2d.velocity.x);
		absVelY = System.Math.Abs (body2d.velocity.y);
		
		standing = absVelY <= standingThreshold;
	}
}
