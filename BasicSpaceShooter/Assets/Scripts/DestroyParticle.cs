using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyParticle : MonoBehaviour {

    float timeToDestroy;

	// Use this for initialization
	void Start () {

        timeToDestroy = Time.time + 1f;
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Time.time > timeToDestroy)
        {
            Destroy(gameObject);
        }
		
	}
}
