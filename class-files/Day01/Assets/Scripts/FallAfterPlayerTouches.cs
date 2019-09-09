using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallAfterPlayerTouches : MonoBehaviour {

    [SerializeField] private float timeUntilFall = 0.5f;
    [SerializeField] private Color fallingColor = Color.red;
	bool hasFallen = false;
	
	// Message sent from FPSController
	void ControllerHit() {
		InitiateFall();
	}

	void InitiateFall() {
		if (!hasFallen) {
			Invoke("Fall", timeUntilFall);
			GetComponent<MeshRenderer>().material.color = fallingColor;
			hasFallen = true;
		}
	}

	void Fall() {
		gameObject.AddComponent<Rigidbody>();
	}
}
