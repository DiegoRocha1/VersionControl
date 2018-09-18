using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;
	public float jumpPower;

	public Rigidbody2D rbody;

	float horiz;
	bool jump;

	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
		horiz = Input.GetAxis ("Horizontal") * speed;
		rbody.AddForce (new Vector2 (horiz, 0f));
		jump = Input.GetButtonDown ("Jump");
	}
	void FixedUpdate(){
		// rbody.AddForce (new Vector2 (horiz, 0f));
		rbody.velocity = new Vector2 (horiz, rbody.velocity.y);
		
		if(jump){
			rbody.AddForce (new Vector2 (0f, jumpPower), ForceMode2D.Impulse);
		}
	}
}
