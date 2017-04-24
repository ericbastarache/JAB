using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	private bool ballIsActive;
	private Vector3 ballPosition;
	private Vector2 ballInitialForce;

	public GameObject playerObject;

	void Start () {
		ballInitialForce = new Vector2 (100.0f, 300.0f);
		ballIsActive = false;
		ballPosition = transform.position;
	}

	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			if (!ballIsActive) {
				GetComponent<Rigidbody2D>().AddForce (ballInitialForce);
				ballIsActive = !ballIsActive;
			}
		}
		if (!ballIsActive && playerObject != null) {
			ballPosition.x = playerObject.transform.position.x;
			transform.position = ballPosition;
		}
	}
}
