using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin_miniBoss : MonoBehaviour {
	[SerializeField]
	Transform Player;

	public Transform AttackPos;
	public Animator anim;
	private float timeBtwattack;
	public float startTimeBtwAttack;
	public LayerMask whatIsEnemy;
	[SerializeField]
	float AttackRange1;
	public int Damage;




	// Use this for initialization
	void Start()
	{
		anim = GetComponent<Animator>();
	}

	void FixedUpdate()
	{
		float DisToPlayer1 = Vector2.Distance(transform.position, Player.position);

		if (DisToPlayer1 <= AttackRange1)
		{
			// if the player is between the melee range and the spell range the enemy will run after him and melee attack him
			//ChasePlayer();

			MeleeAttack();
			Flip();

		}

	}

	


	void Flip()
	{
		if (transform.position.x <= Player.position.x)
		{
			//enemy is on the left side of the player so move right
			transform.localScale = new Vector2(1, 1);

		}
		else
		{
			// enemy is on the right side of the player so move left
			transform.localScale = new Vector2(-1, 1);
		}
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			FindObjectOfType<PlayerStatuslvl3>().TakeDamage(Damage);
			Debug.Log("Damage taken");
		}

	}
	void MeleeAttack()
	{

		float DisToPlayer = Vector2.Distance(transform.position, Player.position);

		if (timeBtwattack <= 0)
		{

			if (DisToPlayer <= AttackRange1)
			{
				anim.SetTrigger("Attack");
				Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(AttackPos.position, AttackRange1, whatIsEnemy);
				for (int i = 0; i < enemiesToDamage.Length; i++)
				{
					enemiesToDamage[i].GetComponent<PlayerStatuslvl3>().TakeDamage(Damage);
				}
			}
			timeBtwattack = startTimeBtwAttack;
		}
		else
		{
			timeBtwattack -= Time.deltaTime;

		}
	}

	void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(transform.position, AttackRange1);

	}
}
