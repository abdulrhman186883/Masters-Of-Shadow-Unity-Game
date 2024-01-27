using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kusho_Boss : MonoBehaviour
{
	[SerializeField]
	Transform Player;

	[SerializeField]
	float SpellRange;

	public GameObject Spell;
	public Transform AttackPos;
	public float FireRate;
	private float NextFireTime;
	public Animator anim;
	private float timeBtwattack;
	public float startTimeBtwAttack;
	public LayerMask whatIsEnemy;
	public float AttackRange;
	public int Damage;




	// Use this for initialization
	void Start()
	{
		anim = GetComponent<Animator>();
	}

	void FixedUpdate()
	{
		float DisToPlayer = Vector2.Distance(transform.position, Player.position);
		

		if (DisToPlayer <= SpellRange && NextFireTime < Time.time)
		{
			//The enemy will hit the player with spell potion
			//play the enemy animation
			HitSpell();
			Flip();
			NextFireTime = Time.time + FireRate;
		}

		else if (DisToPlayer <= AttackRange)
		{
			// if the player is between the melee range and the spell range the enemy will run after him and melee attack him
			//ChasePlayer();

			MeleeAttack();
			Flip();

		}

	}

	void HitSpell()
	{

		Instantiate(Spell, AttackPos.position, Quaternion.identity);
		anim.SetTrigger("SpellAttack");

		//  Quaternion is a function to stop the rotation   
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
			FindObjectOfType<PlayerStatuslvl4>().TakeDamage(Damage);
			Debug.Log("Damage taken");
		}

	}
	void MeleeAttack()
	{
		
		float DisToPlayer = Vector2.Distance(transform.position, Player.position);
		
		if (timeBtwattack <= 0)
		{
			
			if (DisToPlayer <= AttackRange)
			{
				anim.SetTrigger("kushoMelee");
				Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(AttackPos.position, AttackRange, whatIsEnemy);
				for (int i = 0; i < enemiesToDamage.Length; i++)
				{
					
					enemiesToDamage[i].GetComponent<PlayerStatuslvl4>().TakeDamage(Damage);
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
		Gizmos.DrawWireSphere(transform.position, SpellRange);
		Gizmos.DrawWireSphere(transform.position, AttackRange);
		
	}
}
