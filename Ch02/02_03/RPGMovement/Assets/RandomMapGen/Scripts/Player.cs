using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private MapMovementController moveController;

	// Use this for initialization
	void Start () {
		moveController = GetComponent<MapMovementController> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			Debug.Log ("Up key is pressed");
		} else if (Input.GetKeyDown (KeyCode.RightArrow)) {
			Debug.Log ("Right key is pressed");
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			Debug.Log ("Down key is pressed");
		} else if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			Debug.Log ("Left key is pressed");
		}

	}
}
