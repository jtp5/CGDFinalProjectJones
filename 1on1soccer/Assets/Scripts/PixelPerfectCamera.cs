using UnityEngine;
using System.Collections;

public class PixelPerfectCamera : MonoBehaviour {

	public static float pixelsToUnits;
	public static float scale;

	public Vector2 nativeResolution = new Vector2 (400, 160
	                                               );

	void Start () {

		pixelsToUnits = 1f;
		scale = 1f;

		var camera = GetComponent<Camera> ();

		if (camera.orthographic) {
			scale = Screen.height/nativeResolution.y;
			pixelsToUnits *= scale;
			camera.orthographicSize = (Screen.height / 2.0f) / pixelsToUnits;
		}
	}

}
