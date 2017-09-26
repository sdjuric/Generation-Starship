using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {

	public Vector3 bulletOffset = new Vector3(0, 0.5f, 0);

	public GameObject bulletPrefab;
	int bulletLayer;

	public float fireDelay = 0.25f;
	float cooldownTimer = 0;

    public static SoundEffectsHelper Instance;
    public AudioClip laserSound;

    private void MakeSound(AudioClip originalClip)
    {
        // As it is not 3D audio clip, position doesn't matter.
        AudioSource.PlayClipAtPoint(originalClip, transform.position);
    }

    void Start() {
		bulletLayer = gameObject.layer;
	}

	void Update () {
		cooldownTimer -= Time.deltaTime;

		if( Input.GetButton("Fire1") && cooldownTimer <= 0 ) {

			cooldownTimer = fireDelay;

			Vector3 offset = transform.rotation * bulletOffset;

			GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
			bulletGO.layer = bulletLayer;

            MakeSound(laserSound);
		}
	}
}
