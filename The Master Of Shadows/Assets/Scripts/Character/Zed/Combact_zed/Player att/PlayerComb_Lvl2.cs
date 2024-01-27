using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerComb_Lvl2 : MonoBehaviour {

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

			Attack1();
		}
	}

	void Attack1()
	{
		anim.SetTrigger("attack");
		AudioManager.Playclip("ZedHit");
		Collider2D[] hitEnimies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

		for (int i = 0; i < hitEnimies.Length; i++)
		{
			hitEnimies[i].GetComponent<enemyCont_lvl2>().TakeDamage(attackDamage);
			Debug.Log("we hit");
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
