using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour {

	void Awake () {
		
	}
	// Use this for initialization
	void Start () {
		gameObject.SetActive(false);
	}

	void FixedUpdate () {
		Debug.Log((string)Input.inputString);
		if (Input.GetKeyDown(KeyCode.Escape)) {
			PauseGame();
		} else {
			ResumeGame();
		}
	}

	private void PauseGame() {
		Time.timeScale = 0;
		gameObject.SetActive(true);
	}

	private void ResumeGame () {
		Time.timeScale = 1;
		gameObject.SetActive (false);
	}
}
