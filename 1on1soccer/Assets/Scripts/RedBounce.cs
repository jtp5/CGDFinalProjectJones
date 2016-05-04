using UnityEngine;
using System.Collections;

public class RedBounce : MonoBehaviour {
	
	
	void OnTriggerEnter2D(Collider2D other)
	{
		
		Debug.Log ("hit zombie");
		
		Rigidbody2D otherBody = other.GetComponent<Rigidbody2D> ();
		otherBody.velocity = new Vector2 (60, 50);
		
	}

}