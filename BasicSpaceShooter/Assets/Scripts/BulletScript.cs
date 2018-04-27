using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    int damage;
    public bool isEnemyBullet;

	// Use this for initialization
	void Start () {

        if (gameObject.tag == "Bullet2x4Damage1" || gameObject.tag == "Bullet1x1Damage1")
        {
            damage = 1;
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "BulletWall" || collider.gameObject.tag == "EnemyWall")
        {
            Destroy(gameObject);
        }
        
        else if (collider.gameObject.tag == "Enemy1" && !isEnemyBullet)
        {
            collider.gameObject.GetComponent<EnemyShoot>().health -= damage;
            Destroy(gameObject);
        }

        else if (collider.gameObject.tag == "Player" && isEnemyBullet)
        {
            collider.gameObject.GetComponent<PlayerShoot>().health -= damage;
            Destroy(gameObject);
        }
    }

}
