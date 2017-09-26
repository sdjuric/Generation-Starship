using UnityEngine;
using System.Collections;

public class AsteroidSpawner : MonoBehaviour {

	public GameObject enemyPrefab;

	float spawnDistance = 12f;
    float numEnemies = 5f;
	float enemyRate = 1;
	float nextEnemy = 1;

	// Update is called once per frame
	void Update () {
		nextEnemy -= Time.deltaTime;

		if(nextEnemy <= 0) {
			nextEnemy = enemyRate;
			enemyRate *= 0.5f;
            if (enemyRate < 0.5)
                enemyRate = 1;

            Vector3 offset = Random.onUnitSphere;
			offset.z = 0;
			offset = offset.normalized * spawnDistance;
			Instantiate(enemyPrefab, transform.position + offset, Quaternion.identity);
		}
	}
}
