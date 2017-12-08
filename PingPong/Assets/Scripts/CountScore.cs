using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountScore : MonoBehaviour {

	public Text ScoreBoard;
	public GameObject ball;

	public static bool canAddScore = true;


	private int player1Score = 0;
	private int player2Score = 0;


	// Use this for initialization
	void Start () {
		ball = GameObject.Find("ball");
	}
	
	// Update is called once per frame
	void Update () {

		if (ball.transform.position.x >= 10.5f && canAddScore) {
			canAddScore = false;
			player1Score++;
		}

		if(ball.transform.position.x <= -10.5f && canAddScore) {
			canAddScore = false;
			player2Score++;
		}


		if(player1Score >= 5) {
			SceneManager.LoadScene(2);
		}

		if(player2Score >= 5) {
			SceneManager.LoadScene(2);
		}


		ScoreBoard.text = player1Score.ToString() + " - " + player2Score.ToString();

		
	}
}
