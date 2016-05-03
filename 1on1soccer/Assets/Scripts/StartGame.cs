using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if(Input.GetKey (KeyCode.Space))
		  {
			Application.LoadLevel (1);
		}
	}

}