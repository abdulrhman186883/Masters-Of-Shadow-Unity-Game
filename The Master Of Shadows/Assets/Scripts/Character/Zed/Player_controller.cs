using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_controller : MonoBehaviour
{
    public float moveSpeed;
    public float jumpHeight;
    bool isFacingRight;
    public KeyCode Spacebar;
    public KeyCode L;
    public KeyCode R;
    public KeyCode Kunai_Fire_Key;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    public bool grounded;
    public Transform firePoint;
    public GameObject kunai;
    public Animator anim;

    public Transform key_follow;

    public key followingkey;


    [SerializeField]
    private Transform barrel;
    
    [SerializeField]
    private GameObject bullet;
    
    [SerializeField]
    private GameObject[] ammo;
    
    //private int ammoAmount;



    void Start()
    {
        isFacingRight = true;
        anim = GetComponent<Animator>();

        //for (int i = 0; i <= 5; i++)
        //{
        //    ammo[i].gameObject.SetActive(false);

        //}
        //ammoAmount = 0;

    }

    void Update()
    {

            if (Input.GetKeyDown(Kunai_Fire_Key) && Kunai.ammoAmount > 0)
        {
            Shoot();
        }
        if (Input.GetKeyDown(Spacebar) && grounded)
        {
            jump();
        }
        anim.SetBool("grounded", grounded);

        if (Input.GetKeyDown(Spacebar) && grounded)
        {
            jump();

        }
        if (Input.GetKey(L))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);

            if (isFacingRight)
            {
                flip();
                isFacingRight = false;
            }
        }

        if (Input.GetKey(R))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            if (!isFacingRight)
            {
                flip();
                isFacingRight = true;
            }
        }
        //define animator conditions 
        anim.SetFloat("speed", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));
        anim.SetBool("grounded", grounded);

  
}
    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }



  

    void jump()
    {
        AudioManager.Playclip("Jump");
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
    }
    void flip()
    {
        transform.localScale = new Vector3(-(transform.localScale.x), transform.localScale.y, transform.localScale.z);
    }
    public void Shoot()
    {
        Instantiate(kunai, firePoint.position, firePoint.rotation);
        Kunai.ammoAmount -= 1;
        //ammo[ammoAmount].gameObject.SetActive(false);
        anim.SetTrigger("shoot");
        

    }




}