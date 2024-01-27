using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniBossCompact : MonoBehaviour {
	public Transform attackPoint;
	public float attackRange = 0.3f;
	public int attackDamage;
	public LayerMask enemyLayers;
	public Animator anim;
	

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Q))
		{

			Attack3();
		}
	}
	void Attack3()
	{
		anim.SetTrigger("attack");
		AudioManager.Playclip("ZedHit");
		Collider2D[] hitEnimies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

		for (int i = 0; i < hitEnimies.Length; i++)
		{
			hitEnimies[i].GetComponent<Goblin_Status>().TakeDamage(attackDamage);

			Debug.Log("we hit kusho");
		}
	}



	void OnDrawGizmosSelected()
	{
		if (attackPoint == null)
		{
			return;
		}
		Gizmos.DrawWireSphere(attackPoint.position, attackRange);
	}
}
