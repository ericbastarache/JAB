using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketController : MonoBehaviour {

	public float speed = 100.0f;
	private Vector3 playerPosition;

//	void FixedUpdate () {
//		float horiz = Input.GetAxisRaw("Mouse X");
//		Cursor.visible = false;
//		GetComponent<Rigidbody2D>().velocity = Vector2.right * horiz * speed;
//	}
	void Start () {
		playerPosition = gameObject.transform.position;
	}
	void FixedUpdate () {
		Cursor.visible = false;
		playerPosition.x += Input.GetAxisRaw ("Mouse X") * speed;

		transform.position = playerPosition;
	}
}
