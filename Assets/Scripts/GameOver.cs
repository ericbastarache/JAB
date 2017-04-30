﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

	public LevelManager levelManager;
	// Use this for initialization
	public void MainMenu () {
		levelManager.LoadLevel ("Start Menu");
	}

	public void PlayAgain () {
		levelManager.LoadLevel ("Level_01");
	}

	public void ExitGame () {
		Application.Quit ();
	}
}
