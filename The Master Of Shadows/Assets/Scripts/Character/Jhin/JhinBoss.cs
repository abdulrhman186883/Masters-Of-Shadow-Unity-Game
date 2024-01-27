using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JhinBoss : MonoBehaviour {
	[SerializeField]
	Transform Player;
	public Transform AttackPos;
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
		//transform.localScale = new Vector3(2.5f, 2.5f, 0f);
		float DisToPlayer = Vector2.Distance(transform.position, Player.position);




		if (DisToPlayer <= AttackRange)
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

			transform.localScale = new Vector3(-2.5f, 2.5f, 0f);
			

		}
		else
		{
			// enemy is on the right side of the player so move left
			transform.localScale = new Vector3(2.5f, 2.5f, 0f);

		}
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			FindObjectOfType<Player_Stats>().TakeDamage(Damage);
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
			 //transform.localScale = new Vector3(2.5f, 2.5f, 0f);
				anim.SetTrigger("Jhin_Att");
				Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(AttackPos.position, AttackRange, whatIsEnemy);
				for (int i = 0; i < enemiesToDamage.Length; i++)
				{

					enemiesToDamage[i].GetComponent<PlayerStatuslvl2>().TakeDamage(Damage);
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
		Gizmos.DrawWireSphere(transform.position, AttackRange);

	}
}
