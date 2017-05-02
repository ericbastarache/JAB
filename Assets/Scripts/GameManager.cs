using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {


	public float lives = 3f;
	public float score = 0f;
	public float coinChance = 0.3f;
	public float growPaddleChance = 0.2f;
	public float extraLife = 0.05f;
	public float multipleBall = 0.1f;
	public float shrinkPowerDown = 0.3f;
	public float stickyPower = 0.4f;
	public float paddleUp = 0.25f;
	public float starPower = 0.02f;
	public float super = 0.01f;

	public Text scoreText;
	public Text livesText;
	public LevelManager levelManager;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
