using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour {

	[SerializeField] private GameObject go;
	private bool isPauseActive = false;
	public LevelManager levelManager;
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

	public void MenuScreen () {
		levelManager.LoadLevel ("Start Menu");
	}
}
