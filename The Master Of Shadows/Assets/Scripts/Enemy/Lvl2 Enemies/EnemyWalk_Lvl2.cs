using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWalk_Lvl2 : enemyCont_lvl2
{

	void FixedUpdate()
	{
		if (this.isFacingRight)
		{
			this.GetComponent<Rigidbody2D>().velocity =
			new Vector2(maxSpeed, this.GetComponent<Rigidbody2D>().velocity.y);

		}
		else
		{
			this.GetComponent<Rigidbody2D>().velocity =
			new Vector2(-maxSpeed, this.GetComponent<Rigidbody2D>().velocity.y);
		}
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.tag == "Wall") { flip(); }
		if (collider.tag == "Enemy") { flip(); }
		if (collider.tag == "Player")
		{
			FindObjectOfType<PlayerStatuslvl2>().TakeDamage(damage);
			flip();
		}
	}
}

