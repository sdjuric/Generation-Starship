using UnityEngine;
using System.Collections;

public class AsteroidSpawner2 : MonoBehaviour {

	public GameObject enemyPrefab1;
    public GameObject enemyPrefab2;

    float spawnDistance = 12f;
    float numEnemies = 5f;
	float enemyRate = 1;
	float nextEnemy = 1;

	// Update is called once per frame
	void Update () {
		nextEnemy -= Time.deltaTime;

		if(nextEnemy <= 0) {
			nextEnemy = enemyRate;
			enemyRate *= 0.9f;
            if (enemyRate < 0.25)
                enemyRate = 1;

            Vector3 offset = Random.onUnitSphere;
			offset.z = 0;
			offset = offset.normalized * spawnDistance;
			Instantiate(enemyPrefab1, transform.position + offset, Quaternion.identity);
            Instantiate(enemyPrefab2, transform.position + offset, Quaternion.identity);
        }
	}
}
