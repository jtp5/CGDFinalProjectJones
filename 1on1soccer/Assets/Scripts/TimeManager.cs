using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour {

	public float startingTime;

	private Text theText;

	// Use this for initialization
	void Start () {
	
		theText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		startingTime -= Time.deltaTime; 

		if (startingTime <= 0) {

		}

		theText.text = "" + Mathf.Round (startingTime);
	}
}
