﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour {

	public GameObject projectile;

	// Use this for initialization
	void Start () {
			
	}
	
	// Update is called once per frame
	void Update () {

		// Fires the projectile
		if (Input.GetButtonDown ("Jump")) {
			Instantiate (projectile, transform.position, transform.rotation);
		}
	}
}
