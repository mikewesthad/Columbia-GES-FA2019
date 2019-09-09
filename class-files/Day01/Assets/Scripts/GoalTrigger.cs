using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalTrigger : MonoBehaviour {

	[SerializeField] private AudioSource audio;
    [SerializeField] private ParticleSystem particleSystem;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter() {
		audio.Play();
		particleSystem.Play();
	}
}
