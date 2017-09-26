using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class PlayerProperties2 : MonoBehaviour {

	public int health = 3;
	public float invulnPeriod = 0;
	float invulnTimer = 0;
	int correctLayer;
	SpriteRenderer spriteRend;

    GameObject playerInstance;

    float timeLeft = 30.0f;

    public GameObject explosionPrefab;

    void Start() {
		correctLayer = gameObject.layer;
		spriteRend = GetComponent<SpriteRenderer>();

		if(spriteRend == null) {
			spriteRend = transform.GetComponentInChildren<SpriteRenderer>();

			if(spriteRend==null) {
				Debug.LogError("Object '"+gameObject.name+"' has no sprite renderer.");
			}
		}
	}

	void OnTriggerEnter2D() {
		health--;

		if(invulnPeriod > 0) {
			invulnTimer = invulnPeriod;
			gameObject.layer = 10;
		}
	}

    void OnGUI()
    {
        if (health > 0 || playerInstance != null)
        {
            GUI.Label(new Rect(0, 0, 100, 50), "Survive for: " + Math.Floor(timeLeft));
            GUI.Label(new Rect(0, 10, 100, 50), "Lives Left: " + health);
        }
    }

    void Update() {

        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            SceneManager.LoadScene("Stage3");
        }

        if (invulnTimer > 0) {
			invulnTimer -= Time.deltaTime;

			if(invulnTimer <= 0) {
				gameObject.layer = correctLayer;
				if(spriteRend != null) {
					spriteRend.enabled = true;
				}
			}
			else {
				if(spriteRend != null) {
					spriteRend.enabled = !spriteRend.enabled;
				}
			}
		}

		if(health <= 0) {
			Die();
		}
	}

	void Die() {
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
        SceneManager.LoadScene("Defeat2");
    }

}
