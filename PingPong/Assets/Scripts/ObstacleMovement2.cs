using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement2 : MonoBehaviour {

	private Vector3 startPos2;

	private Vector3 secondPos2;

	private Vector3 nextPos2;

	[SerializeField]
	private float speed2;

	[SerializeField]
	private Transform positionTransform2;

	[SerializeField]
	private Transform transformB2;

	// Use this for initialization
	void Start () {
		
		startPos2 = positionTransform2.localPosition;
		secondPos2 = transformB2.localPosition;
		nextPos2 = secondPos2;
		
	}

	// Update is called once per frame
	void Update () {
		movement2();
	}

	private void movement2() {
		positionTransform2.localPosition = Vector3.MoveTowards(positionTransform2.localPosition,nextPos2,speed2 * Time.deltaTime);

		if(Vector3.Distance(positionTransform2.localPosition,nextPos2) <= 0.1) {
			goBack2();
		}
	}

	private void goBack2() {
		nextPos2 = nextPos2 != startPos2 ? startPos2:secondPos2;
	}
}
