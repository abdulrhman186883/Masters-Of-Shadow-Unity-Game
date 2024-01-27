using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    public int damage;
    void OnTriggerEnter2D(Collider2D other)
    {
       // if (other.tag == "Player")
        //StartCoroutine(wait());
        
        if (other.tag == "Player")
        {
            FindObjectOfType<Player_Stats>().TakeDamage(damage);
            //FindObjectOfType<PlayerStatuslvl2>().TakeDamage(damage);
            //FindObjectOfType<PlayerStatuslvl3>().TakeDamage(damage);
            //FindObjectOfType<PlayerStatuslvl4>().TakeDamage(damage);
            FindObjectOfType<Level_Manager>().RespawnPlayer();

        }
    }

    //IEnumerator wait()
    //{
       
    //    yield return new WaitForSecondsRealtime(5);
      
    //}

}