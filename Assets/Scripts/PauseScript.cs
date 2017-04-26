using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour {

	[SerializeField] private GameObject go;
	private bool isPauseActive = false;
	// Use this for initialization
	void Start () {
		go.SetActive(false);
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			TogglePauseMenu ();
		}
	}

	public void TogglePauseMenu () {
		isPauseActive = !isPauseActive;
		Time.timeScale = Convert.ToInt32(!isPauseActive);
		go.SetActive(isPauseActive);
	}
}
