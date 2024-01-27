using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObsLvl3 : MonoBehaviour {

    
		Rigidbody2D rb;
	public int Damage;
	// Use this for initialization
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag.Equals("Player"))
		{
			rb.isKinematic = false;
		}
	}
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag.Equals("Player"))
		{
			FindObjectOfType<PlayerStatuslvl3>().TakeDamage(Damage);
			FindObjectOfType<Level_Manager>().RespawnPlayer();
			Destroy(this.gameObject);
		}
	}
}
