using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour {


    Vector3 pos;
    float speed;

    // Use this for initialization
    void Start () {

        speed = 20f;

	}
	
	// Update is called once per frame
	void Update () {

        pos = Input.mousePosition;
        pos.z = transform.position.z - Camera.main.transform.position.z;
        //transform.position = Camera.main.ScreenToWorldPoint(pos);
    }

    private void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, Camera.main.ScreenToWorldPoint(pos), speed * Time.deltaTime);
    }
}
