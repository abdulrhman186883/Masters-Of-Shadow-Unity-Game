using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour {

	private Player_controller theplayer;

	//for the open door 
	public SpriteRenderer thesr;
	public Sprite dooropensprite;

	public bool dooropen, waitingto_open;




	// Use this for initialization of finding the key 
	void Start()
	{
		theplayer = FindObjectOfType<Player_controller>();
	}

	// Update is called once per frame
	void Update()
	{

		//check if the door is opened or not if not do all down 
		if (waitingto_open)
		{
			
			if (Vector3.Distance(theplayer.followingkey.transform.position, transform.position) < 0.1f)
			{
				waitingto_open = false;
				dooropen = true;
				thesr.sprite = dooropensprite;
				theplayer.followingkey.gameObject.SetActive(false);
				theplayer.followingkey = null;
				AudioManager.Playclip("TakingShadowbox");
			}
		}
	}
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			if (theplayer.followingkey != null)
			{
				theplayer.followingkey.followTarget = transform;
				waitingto_open = true;
			}
		}
	}
}

