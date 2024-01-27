using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesLvl3 : MonoBehaviour {
    public int damage;
    void OnTriggerEnter2D(Collider2D other)
    {
        // if (other.tag == "Player")
        //StartCoroutine(wait());

        if (other.tag == "Player")
        {

            FindObjectOfType<PlayerStatuslvl3>().TakeDamage(damage);
 
            FindObjectOfType<Level_Manager>().RespawnPlayer();

        }
    }
}
