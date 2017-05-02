using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public double lives = 3;
	public double coinChance = 0.3;
	public double growPaddleChance = 0.2;
	public double extraLife = 0.05;
	public double multipleBall = 0.1;
	public double shrinkPowerDown = 0.3;
	public double stickyPower = 0.4;
	public double paddleUp = 0.25;
	public double starPower = 0.02;
	public double super = 0.01;

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
