using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour {

	HUDScript hud;
	private int coinVal = 150;
	// Use this for initialization
	void Start () {
		hud = GameObject.FindWithTag ("Hud").GetComponent<HUDScript> ();
	}

	// Update is called once per frame
	void Update () {
		Vector3 paddlePos = new Vector3(0f, this.transform.position.y, 0f);
		float mousePos = Input.mousePosition.x / Screen.width * 16.8f - 8.4f;

		paddlePos.x = Mathf.Clamp(mousePos, -8.4f, 8.4f);

		this.transform.position = paddlePos;
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.tag == "Coin") {
			hud.updateScore (coinVal);
			Destroy (col.gameObject);
		}
		if (col.gameObject.tag == "") {

		}
	}
}
