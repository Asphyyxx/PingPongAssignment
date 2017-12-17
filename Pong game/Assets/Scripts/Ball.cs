using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	
	private Rigidbody2D rb;
	public GameObject Player1;
	public GameObject Player2;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D>();
		Player1 = GameObject.Find("Player1");
		Player2 = GameObject.Find("Player2");

		StartCoroutine (Pause ());
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Mathf.Abs(this.transform.position.x) >= 11f) {
			CountScore.canAddScore = true;
			CountScoreLevel2.canAddScorelvl2 = true;
			CountScoreLvl3.canAddScorelvl3 = true;
			this.transform.position = new Vector3(0f,0f,0f);
			StartCoroutine (Pause ());
			
		}

	}

	IEnumerator Pause() {
		
		int directionX = Random.Range(-1,2);
		int directionY = Random.Range(-1,2);


		if(directionX == 0 ) {
			directionX = 1;
		}

		rb.velocity = new Vector2 (0f, 0f);
		yield return new WaitForSeconds (2);
		rb.velocity = new Vector2 (7f * directionX, 7f*directionY);
	}
}
