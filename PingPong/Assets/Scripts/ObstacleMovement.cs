using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour {

	private Vector3 startPos;

	private Vector3 secondPos;

	private Vector3 nextPos;

	[SerializeField]
	private float speed;

	[SerializeField]
	private Transform positionTransform;

	[SerializeField]
	private Transform transformB;

	// Use this for initialization
	void Start () {
		
		startPos = positionTransform.localPosition;
		secondPos = transformB.localPosition;
		nextPos = secondPos;
		
	}
	
	// Update is called once per frame
	void Update () {
		movement();
	}

	private void movement() {
		positionTransform.localPosition = Vector3.MoveTowards(positionTransform.localPosition,nextPos,speed * Time.deltaTime);

		if(Vector3.Distance(positionTransform.localPosition,nextPos) <= 0.1) {
			goBack();
		}
	}

	private void goBack() {
		nextPos = nextPos != startPos ? startPos:secondPos;
	}
}
