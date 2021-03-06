﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public int health;
	public float speed;
	public float limitLeft, limitRight;
	public GameObject explosionPreFab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		print (health);
		Move ();
	}

	void Move (){

		// Move
		float move_x = Input.GetAxisRaw ("Horizontal") * speed * Time.deltaTime;
		float move_y = Input.GetAxisRaw ("Vertical") * speed * Time.deltaTime;
		transform.Translate (move_x, move_y, 0.0f);

		// Warp
		if (transform.position.x < limitLeft || transform.position.x > limitRight) {
			transform.position = new Vector2 (transform.position.x * -1, transform.position.y);
		}
	}

	void OnCollisionEnter2D(Collision2D c){
		if (c.gameObject.tag == "Enemy") {
			health--;
			Instantiate (explosionPreFab, transform.position, transform.rotation);
			Destroy (c.gameObject);
			if (health <= 0) {
				Destroy (gameObject);
			}
		}
	}
}
