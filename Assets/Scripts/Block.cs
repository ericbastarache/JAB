using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

	// Use this for initialization
	void OnCollisionEnter2D(Collision2D blockCollision) {
		Destroy(gameObject);
	}
}
