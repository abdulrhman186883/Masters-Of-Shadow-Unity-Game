using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_Manager : MonoBehaviour
{

	public GameObject CurrentCheckpoint;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	public void RespawnPlayer()
	{
		FindObjectOfType<Player_controller>().transform.position = CurrentCheckpoint.transform.position;
	}
}