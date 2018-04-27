using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

    public GameObject bullet2x4Damage1GO, bullet1x1Damage1GO;
    float bulletSpeed;
    float bulletfreq, lastShot;
    Vector3 bulletColour;
    public int health;

	// Use this for initialization
	void Start () {

        bulletfreq = 0.2f; //seconds between bullets

        bulletColour = new Vector3(0f ,199f, 255f);

        if (gameObject.name == "Ship1")
        {
            health = 200;
        }


    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.Mouse0) && (Time.time > lastShot))
        {
            Fire();
        }

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    void Fire()
    {
        

        if (gameObject.name == "Ship1")
        {
            
            foreach (Transform childTransform in gameObject.GetComponentInChildren<Transform>())
            {
                Vector3 pos = childTransform.position;

                string tag = childTransform.gameObject.tag;

                switch (tag)
                {
                    case "Bullet2x4Damage1":
                        {
                            bulletSpeed = 15f; //movement speed of bullet                          
                            GameObject newBullet = Instantiate(bullet2x4Damage1GO, pos, Quaternion.identity);
                            newBullet.GetComponent<SpriteRenderer>().color = new Color(bulletColour.x, bulletColour.y, bulletColour.z);
                            newBullet.GetComponent<Rigidbody2D>().velocity = Vector2.up * bulletSpeed;
                            break;
                        }

                    case "Bullet1x1Damage1":
                        {
                            bulletSpeed = 25f; //movement speed of bullet
                            GameObject newBullet = Instantiate(bullet1x1Damage1GO, pos, Quaternion.identity);
                            newBullet.GetComponent<SpriteRenderer>().color = new Color(bulletColour.x, bulletColour.y, bulletColour.z);
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
