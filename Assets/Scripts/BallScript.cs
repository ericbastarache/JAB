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
		if (col.gameObject.tag == "Paddle") {
			float x = hitPosition (this.transform.position, col.transform.position, 0.96f);
			Vector2 dir = new Vector2 (x, 1).normalized;
			GetComponent<Rigidbody2D>().velocity = dir * speed;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (!hasStarted) {
			this.transform.position = paddle.transform.position + paddleToBall;
			if (Input.GetMouseButtonDown (0)) {
				hasStarted = true;
				GetComponent<Rigidbody2D> ().velocity = new Vector2(2f, -10f);
			}
		}
	}
}
