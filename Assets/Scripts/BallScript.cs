using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

	public PaddleScript paddle;

	private bool hasStarted = false;
	private Vector3 paddleToBall;
	private Vector3 initialBallPos;
	private Vector3 paddleInitialPos;
	private float speed = 10f;

	// Use this for initialization
	void Start () {
		initialBallPos = this.transform.position;
		paddleInitialPos = paddle.transform.position;
		paddleToBall = this.transform.position - paddle.transform.position;


	}

	public void Restart() {
		paddleToBall = initialBallPos - paddleInitialPos;
		hasStarted = false;
	}

	float hitPosition (Vector2 ballPos, Vector2 racketPos, float racketWidth) {
		return (ballPos.x - racketPos.x) / racketWidth;
	}

	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag == "Player") {
			float x = hitPosition (this.transform.position, col.transform.position, col.collider.bounds.size.x);
			calculateVelocity (x);
		}
	}

	void calculateVelocity (float s) {
		Vector2 dir = new Vector2 (s, 1).normalized;
		Vector2 vel = dir * speed;
		Vector2 tweak = new Vector2 (Random.Range(0f, 0.7f), Random.Range(0f, 0.7f));
		GetComponent<Rigidbody2D> ().velocity = vel + tweak;
	}
		
	// Update is called once per frame
	void Update () {
		if (!hasStarted) {
			this.transform.position = paddle.transform.position + paddleToBall;
			if (Input.GetMouseButtonDown(0)) {
				hasStarted = true;
				GetComponent<Rigidbody2D> ().velocity = new Vector2(2f, 10f);
			}
		}
	}
}
