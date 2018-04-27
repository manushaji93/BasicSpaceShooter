using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {


    float enemySpeed;

	// Use this for initialization
	void Start () {

        enemySpeed = 5f;

        gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.down * enemySpeed;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
