
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pause : MonoBehaviour {
	public Transform pause_Canvas;
	public Transform Buttons;
	//public Transform Player;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			PauseGame ();
		}
	}

	public void Back() {
		Buttons.gameObject.SetActive (true);
	}


	public void PauseGame() {
		if (pause_Canvas.gameObject.activeInHierarchy == false) {
			pause_Canvas.gameObject.SetActive (true);
			Time.timeScale = 0;

		} else {
			pause_Canvas.gameObject.SetActive (false);
			Time.timeScale = 1;

		}
	}
}