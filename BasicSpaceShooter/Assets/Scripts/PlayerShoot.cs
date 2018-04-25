using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

    public GameObject bulletGO;
    float bulletSpeed;
    float bulletfreq, lastShot;

	// Use this for initialization
	void Start () {
        bulletSpeed = 25f; //movement speed of bullet
        bulletfreq = 0.15f; //seconds between bullets
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.Mouse0) && (Time.time > lastShot))
        {
            Fire();
        }
		
	}

    void Fire()
    {
        lastShot = Time.time + bulletfreq;
        GameObject newBullet = GameObject.Instantiate(bulletGO, transform.position, Quaternion.identity);
        newBullet.GetComponent<Rigidbody2D>().velocity = Vector2.up * bulletSpeed;
    }

}
