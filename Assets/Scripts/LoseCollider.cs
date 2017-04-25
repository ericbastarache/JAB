using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {

	public LevelManager levelManager;

	void OnCollisionEnter2D(Collision2D collision) {
		levelManager.LoadLevel("Win Screen");
	}
}
