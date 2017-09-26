using UnityEngine;
using System.Collections;

public class EnemyShoot : MonoBehaviour {

	public Vector3 bulletOffset = new Vector3(0, 0.5f, 0);
	
	public GameObject bulletPrefab;
	int bulletLayer;

	public float fireDelay = 0.50f;
	float cooldownTimer = 0;

	Transform player;

    public AudioClip shootSound;

    private void MakeSound(AudioClip originalClip)
    {
        // As it is not 3D audio clip, position doesn't matter.
        AudioSource.PlayClipAtPoint(originalClip, transform.position);
    }

    void Start() {
		bulletLayer = gameObject.layer;
	}

	void Update () {
		if(player == null) {
			GameObject go = GameObject.FindWithTag ("PlayerShip");

			if(go != null) {
				player = go.transform;
			}
		}

		cooldownTimer -= Time.deltaTime;
		
		if( cooldownTimer <= 0 && player != null && Vector3.Distance(transform.position, player.position) < 4) {
			cooldownTimer = fireDelay;
			Vector3 offset = transform.rotation * bulletOffset;
			GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
			bulletGO.layer = bulletLayer;
            MakeSound(shootSound);
        }
	}
}
