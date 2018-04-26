using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

    public GameObject bullet2x4Damage1GO, bullet1x1Damage1GO;
    float bulletSpeed;
    float bulletfreq, lastShot;

	// Use this for initialization
	void Start () {

        bulletfreq = 0.2f; //seconds between bullets

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
        

        if (gameObject.name == "Ship1")
        {
            
            foreach (Transform childTransform in gameObject.GetComponentInChildren<Transform>())
            {
                Vector3 pos = childTransform.position;
                pos.y += 1f;

                string tag = childTransform.gameObject.tag;

                switch (tag)
                {
                    case "Bullet2x4Damage1":
                        {
                            bulletSpeed = 15f; //movement speed of bullet                          
                            GameObject newBullet = GameObject.Instantiate(bullet2x4Damage1GO, pos, Quaternion.identity);
                            newBullet.GetComponent<Rigidbody2D>().velocity = Vector2.up * bulletSpeed;
                            break;
                        }

                    case "Bullet1x1Damage1":
                        {
                            bulletSpeed = 25f; //movement speed of bullet
                            GameObject newBullet = GameObject.Instantiate(bullet1x1Damage1GO, pos, Quaternion.identity);
                            newBullet.GetComponent<Rigidbody2D>().velocity = Vector2.up * bulletSpeed;
                            break;
                        }

                    default:
                        {
                            break;
                        }
                }

                
                
            }

            lastShot = Time.time + bulletfreq;
        }
        
    }

}
