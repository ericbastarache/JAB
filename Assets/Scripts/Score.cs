using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

	// Use this for initialization
	public int score;
	public void updateScore(int numbers) {
		score += numbers;
	}
}
