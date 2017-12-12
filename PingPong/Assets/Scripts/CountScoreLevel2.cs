using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountScoreLevel2 : MonoBehaviour {

	public Text ScoreBoardlvl2;
	public GameObject ball;

	public static bool canAddScorelvl2 = true;


	public int player1Scorelvl2 = 0;
	public int player2Scorelvl2 = 0;


	// Use this for initialization
	void Start () {
		ball = GameObject.Find("ball");
	}
	
	// Update is called once per frame
	void Update () {

		if (ball.transform.position.x >= 9.5f && canAddScorelvl2) {
			canAddScorelvl2 = false;
			player1Scorelvl2++;
		}

		if(ball.transform.position.x <= -9.5f && canAddScorelvl2) {
			canAddScorelvl2 = false;
			player2Scorelvl2++;
		}


		if(player1Scorelvl2 >= 7) {
			SceneManager.LoadScene(3);
		}

		if(player2Scorelvl2 >= 7) {
			SceneManager.LoadScene(3);
		}


		ScoreBoardlvl2.text = player1Scorelvl2.ToString() + " - " + player2Scorelvl2.ToString();

		
	}
}
