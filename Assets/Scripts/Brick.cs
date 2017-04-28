using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Brick : MonoBehaviour {

	public int maxHits;
	private int timesHit;
	public int score;
	private Text scoreText;
	// Use this for initialization
	void Start () {
		timesHit = 0;
		scoreText = GameObject.Find("Score").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void updateScore (int numbers) {
		score += numbers;
		scoreText.text = score.ToString();
	}

	void OnCollisionEnter2D(Collision2D collision) {
		timesHit++;
		if (timesHit >= maxHits) {
			GetComponent<Score>().updateScore(score);
			Destroy(gameObject);
		}
	}
}
