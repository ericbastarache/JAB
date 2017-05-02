using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDScript : MonoBehaviour {

	public GameManager GM;

	public void updateScore (int amount) {
		GM.score += amount;
		GM.scoreText.text = GM.score.ToString ();
	}

	public void increaseLives() {
		GM.lives++;
		GM.livesText.text = GM.lives.ToString ();
	}

	public void decreaseLives() {
		GM.lives--;
		GM.livesText.text = GM.lives.ToString ();
		if (GM.lives <= 0) {
			GM.levelManager.LoadLevel ("Game Over");
		}
	}
}
