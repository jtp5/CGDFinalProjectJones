using UnityEngine;
using System.Collections;

public class HitZombie : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D other)
	{

		Debug.Log ("hit zombie");
	
		Rigidbody2D otherBody = other.GetComponent<Rigidbody2D> ();

		if (otherBody != null) {
			otherBody.velocity = new Vector2 (-60, 50);

		}

	}
	

}
