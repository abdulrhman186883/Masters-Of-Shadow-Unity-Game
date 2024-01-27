using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObsLvl3 : MonoBehaviour {

    public Transform pos1, pos2;
    public float speed;
    public Transform startPostion;
    Vector3 nextPos;
    public int Damage;
    // Start is called before the first frame update
    void Start()
    {
        nextPos = startPostion.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == pos1.position)
        {
            nextPos = pos2.position;
        }
        if (transform.position == pos2.position)
        {
            nextPos = pos1.position;
        }
        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(pos1.position, pos2.position);
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            FindObjectOfType<PlayerStatuslvl3>().TakeDamage(Damage);
            FindObjectOfType<Level_Manager>().RespawnPlayer();

        }
    }
}
