using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemiesScript : MonoBehaviour {

	public GameObject enemy;
	public float limitLeft, limitRight;
	public float startTime, endTime;

	// Use this for initialization
	IEnumerator Start () {

		// Waits to create a new enemy
		yield return new WaitForSeconds (Random.Range(startTime, endTime));
		// Sorts position in X to instantiate an enemy
		Vector2 position = new Vector2(
			Random.Range(limitLeft, limitRight),
			transform.position.y);

		// Instantiates the enemy
		Instantiate(enemy, position, transform.rotation);

		// Looping 
		StartCoroutine(Start());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
