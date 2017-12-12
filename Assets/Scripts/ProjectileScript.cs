using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour {

	public float speed;
	public float lifeSpam;
	public GameObject explosionPreFab;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, lifeSpam);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.up * speed * Time.deltaTime);
	}

	void OnCollisionEnter2D(Collision2D c){

		// Destroys the projectile by collision
		if (c.gameObject.tag == "Enemy") {
			Instantiate (explosionPreFab, transform.position, transform.rotation);
			Destroy (c.gameObject);
			Destroy (gameObject);
		}
	}
}
