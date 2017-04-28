using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LoseCollider : MonoBehaviour {

	public LevelManager levelManager;

	private float numLives = 3;
	void OnCollisionEnter2D(Collision2D collision) {
		if (collision.gameObject.tag == "Collectable") {
			Destroy (collision.gameObject);
		}
		if (collision.gameObject.tag == "Coin") {
			Destroy (collision.gameObject);
		}
		if (collision.gameObject.tag == "Ball") {
			numLives--;
			if (numLives <= 0) {
				levelManager.LoadLevel ("Win Screen");
			}
		}
	}
}
