using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyCont_lvl2 : MonoBehaviour
{

	public bool isFacingRight = true;
	public float maxSpeed = 0.6f;
	public int damage = 10;
	public int maxHealth = 100;
	int currentHealth;
	public GameObject effect;

	public void flip()
	{
		isFacingRight = !isFacingRight;
		transform.localScale = new Vector3(-(transform.localScale.x), transform.localScale.y, transform.localScale.z);
	}
	void onTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			FindObjectOfType<PlayerStatuslvl2>().TakeDamage(damage);

		}
	}

	void Start()
	{
		currentHealth = maxHealth;

	}
	void Update()
	{
		if (currentHealth <= 0)
		{
			Instantiate(effect, transform.position, Quaternion.identity);
			Destroy(this.gameObject);
			Debug.Log("Enemy died !");
		}
	}
	public void TakeDamage(int damage)
	{
		currentHealth -= damage;

	}
}
