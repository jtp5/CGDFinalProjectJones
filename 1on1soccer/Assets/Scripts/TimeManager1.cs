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


			if (ScoreManager.score > ScoreManager2.score2){

				Application.LoadLevel(2);

			}

			if (ScoreManager2.score2 > ScoreManager.score){
				Application.LoadLevel(3);

			}





		}

		theText.text = "" + Mathf.Round (startingTime);
	
	

	
	
	
	
	
	}
}
