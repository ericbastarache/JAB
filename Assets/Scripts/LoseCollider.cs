using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LoseCollider : MonoBehaviour {

	public LevelManager levelManager;
	HUDScript hud;
	BallScript ball;
	void Start() {
		hud = GameObject.FindWithTag ("Hud").GetComponent<HUDScript>();
		ball = GameObject.FindWithTag ("Ball").GetComponent<BallScript> ();
	}

	void OnCollisionEnter2D(Collision2D collision) {
		if (collision.gameObject.tag == "Collectable") {
			Destroy (collision.gameObject);
		}
		if (collision.gameObject.tag == "Coin") {
			Destroy (collision.gameObject);
		}
		if (collision.gameObject.tag == "Ball") {
			hud.decreaseLives();
			ball.Restart ();
		}
	}
}
