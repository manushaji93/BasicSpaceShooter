using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    Transform[] spawnPoints;

    public GameObject[] enemyShipPrefabs;

    float lastSpawnedAt, spawnFreq;

	// Use this for initialization
	void Start () {

        spawnFreq = 5f;

        spawnPoints = gameObject.GetComponentsInChildren<Transform>();

	}
	
	// Update is called once per frame
	void Update () {

        if (Time.time > lastSpawnedAt)
        {
            SpawnEnemy();
        }
    }

    void SpawnEnemy()
    {

        int randPos = Random.Range(0,spawnPoints.Length);

        GameObject enemy = Instantiate(enemyShipPrefabs[0], spawnPoints[randPos].position, Quaternion.identity);

        lastSpawnedAt = Time.time + spawnFreq;
    }
}
