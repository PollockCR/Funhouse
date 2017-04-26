using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonController : MonoBehaviour {

	public float movementSpeed = 10.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		float forwardSpeed = Input.GetAxis ("Vertical") * movementSpeed;
		float sideSpeed = Input.GetAxis ("Horizontal") * movementSpeed;


		Vector3 speed = new Vector3 (sideSpeed, 0, forwardSpeed);

		CharacterController cc = GetComponent<CharacterController> ();

		cc.SimpleMove (speed);
	}
}
