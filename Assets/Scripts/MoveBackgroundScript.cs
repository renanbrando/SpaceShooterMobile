using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackgroundScript : MonoBehaviour {

	public float limitY;
	public float speed;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		// Moves backghround down
		transform.Translate (Vector2.down * speed * Time.deltaTime);

		// Returns background to its original position 
		if (transform.position.y <= limitY) {
			transform.position = new Vector2 (0.0f, limitY * -1);
		}
	}
}
