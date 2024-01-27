using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicSpell : MonoBehaviour {

    public float speed;
    private Kusho_Boss Kusho;
    private float timeBtwattack;
    public float startTimeBtwAttack;
    public Transform attackPos;
    public LayerMask whatIsEnemy;
    public int Damage;
    public Animator anim;

    
    

    void Start()
    {
        Kusho = FindObjectOfType<Kusho_Boss>();
        if (Kusho.transform.localScale.x < 0)
        {

            transform.localScale = new Vector3((transform.localScale.x), transform.localScale.y, transform.localScale.z);
            speed = -speed;
        }

      
    }

    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
           
            FindObjectOfType<PlayerStatuslvl4>().TakeDamage(Damage);
            Debug.Log("Damage Taken");
            Destroy(gameObject);
        }
       
    }



}
