using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 paddlePos = new Vector3(0f, this.transform.position.y, 0f);
		float mousePos = Input.mousePosition.x / Screen.width * 16;

		paddlePos.x = Mathf.Clamp(mousePos, -8.4f, 8.4f);

		this.transform.position = paddlePos;
	}
}
