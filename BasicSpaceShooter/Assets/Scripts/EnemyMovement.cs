using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyMovement : MonoBehaviour {

    public GameObject enemy1DestroyParticleGO;
    float enemySpeed;
    Text playerHealthText;

	// Use this for initialization
	void Start () {

        enemySpeed = 5f;

        gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.down * enemySpeed;

        playerHealthText = GameObject.FindGameObjectWithTag("PlayerHealthText").GetComponent<Text>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "EnemyWall")
        {
            Destroy(gameObject);
        }

        else if (collider.gameObject.tag == "Player")
        {
            Instantiate(enemy1DestroyParticleGO, transform.position, Quaternion.identity);

            Destroy(gameObject);
            collider.gameObject.GetComponent<PlayerShoot>().health -= 10;

            if (collider.gameObject.GetComponent<PlayerShoot>().health < 0)
                collider.gameObject.GetComponent<PlayerShoot>().health = 0;

            playerHealthText.text = "Health: "+ collider.gameObject.GetComponent<PlayerShoot>().health;
        }
    }
}
