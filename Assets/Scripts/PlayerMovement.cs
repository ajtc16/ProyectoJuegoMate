using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float jumpForce = 8f;
	private Rigidbody2D myBody;
	bool canJump;
	float forwardForce = 0f;
	// Use this for initialization
	void Start () {
		myBody = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Jump()
	{
		if (canJump) 
		{
			FindObjectOfType<AudioManager>().Play("JumpSound");
			canJump = false;
			if (transform.position.x < 0) {
				forwardForce = 1f;
			} else
				forwardForce = 0f;
			myBody.velocity = new Vector2 (forwardForce, jumpForce);
		}


	}

	void OnCollisionEnter2D(Collision2D other)
	{
		canJump = true;
	}
}
