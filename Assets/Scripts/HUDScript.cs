using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDScript : MonoBehaviour {

	int score = 0;
	int lives = 3;
	public Text scoreText;
	public Text livesText;
	public LevelManager levelManager;

	public void updateScore (int amount) {
		score += amount;
		scoreText.text = score.ToString ();
	}

	public void increaseLives() {
		lives++;
		livesText.text = lives.ToString ();
	}

	public void decreaseLives() {
		lives--;
		livesText.text = lives.ToString ();
		if (lives <= 0) {
			levelManager.LoadLevel ("Game Over");
		}
	}
}
