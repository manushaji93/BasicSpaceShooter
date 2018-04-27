using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{

    public GameObject bullet2x4Damage1GO, bullet1x1Damage1GO;
    float bulletSpeed;
    float bulletfreq, lastShot;
    Vector3 bulletColour;
    public int health;

    // Use this for initialization
    void Start()
    {

        bulletfreq = 1f; //seconds between bullets

        bulletColour = new Vector3(255f, 0f, 0f);

        if (gameObject.tag == "Enemy1")
        {
            health = 50;
        }

    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time > lastShot)
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


        if (gameObject.tag == "Enemy1")
        {

            foreach (Transform childTransform in gameObject.GetComponentInChildren<Transform>())
            {
                if (childTransform.gameObject.name == "Gun2" || childTransform.gameObject.name == "Gun7")
                {
                    Vector3 pos = childTransform.position;

                    string tag = childTransform.gameObject.tag;

                    switch (tag)
                    {
                        case "Bullet2x4Damage1":
                            {
                                bulletSpeed = 15f; //movement speed of bullet                          
                                GameObject newBullet = Instantiate(bullet2x4Damage1GO, pos, Quaternion.identity);
                                newBullet.GetComponent<BulletScript>().isEnemyBullet = true;
                                newBullet.GetComponent<SpriteRenderer>().color = new Color(bulletColour.x, bulletColour.y, bulletColour.z);
                                newBullet.GetComponent<Rigidbody2D>().velocity = Vector2.down * bulletSpeed;
                                break;
                            }

                        case "Bullet1x1Damage1":
                            {
                                bulletSpeed = 25f; //movement speed of bullet
                                GameObject newBullet = Instantiate(bullet1x1Damage1GO, pos, Quaternion.identity);
                                newBullet.GetComponent<BulletScript>().isEnemyBullet = true;
                                newBullet.GetComponent<SpriteRenderer>().color = new Color(bulletColour.x, bulletColour.y, bulletColour.z);
                                newBullet.GetComponent<Rigidbody2D>().velocity = Vector2.down * bulletSpeed;
                                break;
                            }

                        default:
                            {
                                break;
                            }
                    }

                }

            }

            lastShot = Time.time + bulletfreq;
        }

    }

}
