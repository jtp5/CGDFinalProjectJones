using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {
	public GameObject Camera;
	// Update is called once per frame
	void Update () {
		if(Input.GetKey (KeyCode.Space))
		  {
			Destroy (Camera);
			Application.LoadLevel (1);
			//Camera.transform.position = new Vector3 (0,0,-10f);
		}
	}

}