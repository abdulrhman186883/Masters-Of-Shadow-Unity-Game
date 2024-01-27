using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goblin_Status : MonoBehaviour {
	public int Health;
	public int lives = 1;
	public float flickerDuration = 0.1f;
	private float flickerTime = 0f;
	private SpriteRenderer spriteRenderer;
	public bool isImmune = false;
	public float immunitDuration = 1.5f;
	private float immunityTime = 0f;
	public Slider HealthUi;
	// Use this for initialization
	void Start()
	{
		spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
	}

	void Update()
	{
		//HealthUi.value = Health;
		if (this.isImmune == true)
		{
			spriteFlicker();
			immunityTime = immunityTime + Time.deltaTime;
			if (immunityTime >= immunitDuration)
			{
				this.isImmune = false;
				this.spriteRenderer.enabled = true;

			}
		}
	}
	public void TakeDamage(int damage)
	{
		if (this.isImmune == false)
		{
			this.Health = this.Health - damage;


			if (this.lives == 1 && this.Health <= 0)
			{
				AudioManager.Playclip("KillingBoss");
				Debug.Log("GameOver");
				Destroy(this.gameObject);
			}
			Debug.Log("Goblin Health :" + this.Health.ToString());
			Debug.Log("Goblin lives :" + this.lives.ToString());
		}

		playerHitReaction();
	}
	void playerHitReaction()
	{
		this.isImmune = true;
		this.immunityTime = 0f;
	}
	void spriteFlicker()
	{
		if (this.flickerTime < this.flickerDuration)
		{
			this.flickerTime = this.flickerTime + Time.deltaTime;
		}
		else if (this.flickerTime >= this.flickerDuration)
		{
			spriteRenderer.enabled = !(spriteRenderer.enabled);
			this.flickerTime = 0;
		}
	}
}
