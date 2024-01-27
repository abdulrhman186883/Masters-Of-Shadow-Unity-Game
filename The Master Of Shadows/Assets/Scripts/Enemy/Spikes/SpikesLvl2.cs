using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesLvl2 : MonoBehaviour {
    public int damage;
    void OnTriggerEnter2D(Collider2D other)
    {
       

        if (other.tag == "Player")
        {

            FindObjectOfType<PlayerStatuslvl2>().TakeDamage(damage);
            FindObjectOfType<Level_Manager>().RespawnPlayer();

        }
    }
}
