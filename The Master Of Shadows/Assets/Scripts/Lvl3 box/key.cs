using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
	private bool isFollowing;

	public float followSpeed;

	public Transform followTarget;


	// Update is called once per frame
	void Update()


	{//check if the key is following to change it's position 
		if (isFollowing)
		{
			transform.position = Vector3.Lerp(transform.position, followTarget.position, followSpeed * Time.deltaTime);
		}
	}
	private void OnTriggerEnter2D(Collider2D other)
	{

		// check if the character of type player it true and the key is not following make it follow by change value to true
		if (other.tag == "Player")
		{
			if (!isFollowing)
			{
				Player_controller theplayer = FindObjectOfType<Player_controller>();
				followTarget = theplayer.key_follow;
				isFollowing = true;
				theplayer.followingkey = this;
			}
		}
	}
}