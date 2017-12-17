using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountScoreLevel2 : MonoBehaviour {

	public Text ScoreBoardlvl2;
	public GameObject ball;

    private int highScore;
    private int highScore2;
    private int score1;
    private int score2;

    public static bool canAddScorelvl2 = true;


	public int player1Scorelvl2 = 0;
	public int player2Scorelvl2 = 0;


	// Use this for initialization
	void Start () {

		ball = GameObject.Find("ball");

        player1Scorelvl2 = PlayerPrefs.GetInt("PlayerPref_INT");
        player2Scorelvl2 = PlayerPrefs.GetInt("PlayerPref_INT2");

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


		if(player1Scorelvl2 == 12) {
            PlayerPrefs.SetInt("PlayerPref_INT", player1Scorelvl2);
            PlayerPrefs.SetInt("PlayerPref_INT2", player2Scorelvl2);

            SceneManager.LoadScene(3);
		}

		if(player2Scorelvl2 == 12) {

            PlayerPrefs.SetInt("PlayerPref_INT2", player2Scorelvl2);
            PlayerPrefs.SetInt("PlayerPref_INT", player1Scorelvl2);
         

            SceneManager.LoadScene(3);
		}


		ScoreBoardlvl2.text = player1Scorelvl2.ToString() + " - " + player2Scorelvl2.ToString();

		
	}
}
