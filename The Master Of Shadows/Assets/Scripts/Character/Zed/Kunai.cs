using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Kunai : MonoBehaviour
{
    public static int ammoAmount = 0;
    public float speed;
    private Player_controller player;
    private float timeBtwattack;
    public float startTimeBtwAttack;
    public Transform attackPos;
    public LayerMask whatIsEnemy;
    public int damage;

    void Start()
    {
        player = FindObjectOfType<Player_controller>();
        if (player.transform.localScale.x < 0)
        {
            transform.localScale = new Vector3(-(transform.localScale.x), transform.localScale.y, transform.localScale.z);
            speed = -speed;
        }


    }

    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            AudioManager.Playclip("ZedHit");
            FindObjectOfType<enemyController>().TakeDamage(damage);
            Debug.Log("Damage Taken");
        }
        
        if (other.tag == "Enemylvl2")
        {
            AudioManager.Playclip("ZedHit");
            FindObjectOfType<enemyCont_lvl2>().TakeDamage(damage);
            Debug.Log("Damage Taken");
        }
        if (other.tag == "Enemylvl3")
        {
            AudioManager.Playclip("ZedHit");
            FindObjectOfType<enemyCont_lvl3>().TakeDamage(damage);
            Debug.Log("Damage Taken");
        }
      
        if (other.tag == "Kusho")
        {
            AudioManager.Playclip("ZedHit");
            FindObjectOfType<Kusho_Status>().TakeDamage(damage);
            Debug.Log("Damage Taken");
        }

        if (other.tag == "Enemy_Goblin")
        {
            AudioManager.Playclip("ZedHit");
            FindObjectOfType<Goblin_Status>().TakeDamage(damage);
            Debug.Log("Damage Taken");
        }
        if (other.tag == "Jhin")
        {
            AudioManager.Playclip("ZedHit");
            FindObjectOfType<JhinStatus>().TakeDamage(damage);
            Debug.Log("Damage Taken Jhin");
        }
        Destroy(gameObject);
    }
}
      




