using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Powerups : MonoBehaviour {

	public PaddleScript paddle;
	private int coinVal = 150;
	HUDScript hud;
	// Use this for initialization
	void Start () {
		hud = GameObject.FindWithTag ("Hud").GetComponent<HUDScript> ();
	}

	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D col) {
		if (paddle) {
			hud.updateScore (coinVal);
			Destroy (this.gameObject);
		}
	}
}
