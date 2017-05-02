using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Brick : MonoBehaviour {

	public int maxHits;
	private int timesHit;
	public int blockVal;
	HUDScript hud;
	public GameManager GM;
	// Use this for initialization
	void Start () {
		timesHit = 0;
		hud = GameObject.FindWithTag ("Hud").GetComponent<HUDScript>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D collision) {
		timesHit++;
		if (timesHit >= maxHits) {
			hud.updateScore (blockVal);
			Destroy(this.gameObject);
			GM.brickCount--;

			if (GM.brickCount <= 0) {
				GM.levelManager.LoadLevel ("Level_02");
			}
		}
	}
}
