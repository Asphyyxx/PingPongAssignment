using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountScore : MonoBehaviour {

	public Text ScoreBoard;
	public GameObject ball;

	public static bool canAddScore = true;

   
	public int player1Score = 0;
	public int player2Score = 0;


	// Use this for initialization
	void Start () {
        PlayerPrefs.DeleteAll();

        ball = GameObject.Find("ball");

        player1Score = PlayerPrefs.GetInt("PlayerPref_INT");
        player2Score = PlayerPrefs.GetInt("PlayerPref_INT2");

       
    }
	
	// Update is called once per frame
	void Update () {

		if (ball.transform.position.x >= 9.5f && canAddScore) {
			canAddScore = false;
			player1Score++;
           
        }

		if(ball.transform.position.x <= -9.5f && canAddScore) {
			canAddScore = false;
			player2Score++;
            
        }



		if(player1Score == 5)  {
            PlayerPrefs.SetInt("PlayerPref_INT", player1Score);
            PlayerPrefs.SetInt("PlayerPref_INT2", player2Score);

            SceneManager.LoadScene(2);
            
        }
  

        if (player2Score == 5) {
            PlayerPrefs.SetInt("PlayerPref_INT2", player2Score);
            PlayerPrefs.SetInt("PlayerPref_INT", player1Score);

            SceneManager.LoadScene(2);
           

        }

       



        ScoreBoard.text = player1Score.ToString() + " - " + player2Score.ToString();


       
       

        
        
    }


    
}
