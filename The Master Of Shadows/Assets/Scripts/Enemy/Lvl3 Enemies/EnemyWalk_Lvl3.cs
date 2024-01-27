﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWalk_Lvl3 : enemyCont_lvl3
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
			FindObjectOfType<PlayerStatuslvl3>().TakeDamage(damage);
			flip();
		}
	}
}

