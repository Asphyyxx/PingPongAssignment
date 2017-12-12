using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controls : MonoBehaviour {
	private Rigidbody2D rb;
	private float boundY = 3.7f;
	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		 float mousePosInUnits = (Input.mousePosition.y / Screen.height * 13f) - 6.5f;
	
		 
		 Vector3 paddlePosition = new Vector3(8.56f, mousePosInUnits, this.transform.position.x);
		 this.transform.position = paddlePosition;

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
