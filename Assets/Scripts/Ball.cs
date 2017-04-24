using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public float speed = 100.0f;

	void Start () {
		GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
	}

	float hitBall (Vector2 ballPos, Vector2 racketPos, float racketWidth) {
		return (ballPos.x - racketPos.x) / racketWidth;
	}

	void onCollisionEnter2D(Collision2D other) {
		if (other.gameObject.name == "paddle_1") {
			float x = hitBall (transform.position, other.transform.position, other.collider.bounds.size.x);

			Vector2 dir = new Vector2(x, 1).normalized;

			GetComponent<Rigidbody2D>().velocity = dir * speed;
		}
	}
}
