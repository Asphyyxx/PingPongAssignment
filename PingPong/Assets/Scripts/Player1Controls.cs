using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controls : MonoBehaviour {
	private float Speed;
	private float boundY = 3.7f;
	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		Speed = 5;
		rb = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		float axisX = Input.GetAxis("Vertical");
		float axisY = Input.GetAxis("Horizontal");

		transform.Translate(new Vector2(axisY,axisX) * Time.deltaTime * Speed);

		var pos = transform.position;
		if(pos.y > boundY) {
			pos.y = boundY;
		}

		else if(pos.y <- boundY) {
			pos.y = -boundY;
		}
		transform.position = pos;
	}		
}


