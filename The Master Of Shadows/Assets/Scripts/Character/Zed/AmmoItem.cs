using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoItem : MonoBehaviour
{
    
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            Kunai.ammoAmount += 1;
            Destroy(gameObject);
        }
    }
}