using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountScoreLvl3 : MonoBehaviour
{

    public Text ScoreBoardlvl3;
    public GameObject ball;

    public static bool canAddScorelvl3 = true;


    public int player1Scorelvl3 = 0;
    public int player2Scorelvl3 = 0;


    // Use this for initialization
    void Start()
    {
        ball = GameObject.Find("ball");

        player1Scorelvl3 = PlayerPrefs.GetInt("PlayerPref_INT");
        player2Scorelvl3 = PlayerPrefs.GetInt("PlayerPref_INT2");

    }

	

    // Update is called once per frame
    void Update()
    {

        if (ball.transform.position.x >= 9.5f && canAddScorelvl3)
        {
            canAddScorelvl3 = false;
            player1Scorelvl3++;
        }

        if (ball.transform.position.x <= -9.5f && canAddScorelvl3)
        {
            canAddScorelvl3 = false;
            player2Scorelvl3++;
        }


		if(player1Scorelvl3 == 21) {

            PlayerPrefs.SetInt("PlayerPref_INT", player1Scorelvl3);
            PlayerPrefs.SetInt("PlayerPref_INT2", player2Scorelvl3);
            SceneManager.LoadScene(4);
		}

		if(player2Scorelvl3 == 21) {

            SceneManager.LoadScene(5);

            PlayerPrefs.SetInt("PlayerPref_INT2", player2Scorelvl3);
            PlayerPrefs.SetInt("PlayerPref_INT", player1Scorelvl3);
           
        }

        ScoreBoardlvl3.text = player1Scorelvl3.ToString() + " - " + player2Scorelvl3.ToString();

    }
}

