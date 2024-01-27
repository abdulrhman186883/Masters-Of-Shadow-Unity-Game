using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Stats : MonoBehaviour {

	public int health;
	public int lives;
	public float flickerDuration = 0.1f;
	private float flickerTime = 0f;
	private SpriteRenderer spriteRenderer;
	public bool isImmune = false;
	public float immunitDuration = 1.5f;
	private float immunityTime = 0f;
	public Animator anim;
	public Slider health_UI;
	// Use this for initialization
	void Start()
	{
		spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
		anim = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update()
	{
		health_UI.value = health;
		if (this.isImmune)
		{
			spriteFlicker();
			immunityTime += Time.deltaTime;
			if (immunityTime >= immunitDuration)
			{
				this.isImmune = false;
				this.spriteRenderer.enabled = true;

			}
		}
	}
	public void TakeDamage(int Damage)
	{
		
		if (this.isImmune == false)
		{
			AudioManager.Playclip("First hit");
			this.health -= Damage;
			
			if (this.health < 0)
			{
				this.health = 0;

			}
			
			if (this.lives > 0 && this.health == 0)
			{
				AudioManager.Playclip("death");
				FindObjectOfType<Level_Manager>().RespawnPlayer();
				this.health = 100;
				this.lives--;
				
			}
			else if (this.lives == 0 && this.health == 0)
			{
				(new NavigationController()).GoToGameOver1();

				Debug.Log("GameOver"); 
				
				Destroy(this.gameObject);
			}
			Debug.Log("player Health :" + this.health.ToString());
			Debug.Log("player lives :" + this.lives.ToString());
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
