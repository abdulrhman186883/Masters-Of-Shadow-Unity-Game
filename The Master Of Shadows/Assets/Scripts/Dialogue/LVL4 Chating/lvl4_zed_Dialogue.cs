using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvl4_zed_Dialogue : MonoBehaviour {

	public Dialogue Dmanager;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			string[] dialogue = { "Zed: YOU GOING TO DIE MY MASTER!!",
			"Kusho: Your understanding is wrong Zed!!","Kusho: But you seem like you made a decision"};


			Dmanager.SetSentences(dialogue);
			Dmanager.StartCoroutine(Dmanager.TypeDialogue());
		}
		Destroy(gameObject);
	}
}
