using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Powerups : MonoBehaviour {

	public PaddleScript paddle;
	private float coinVal = 150;
	public Text scoreText;
	// Use this for initialization
	void Start () {
		scoreText = GameObject.Find("Score").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D pUp) {
		if (pUp.gameObject.tag == "Coin") {
			scoreText.text += Convert.ToString(coinVal);
			Destroy(gameObject);
		}
	}
}
