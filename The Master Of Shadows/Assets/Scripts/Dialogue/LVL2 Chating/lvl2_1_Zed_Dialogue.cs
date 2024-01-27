using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvl2_1_Zed_Dialogue : MonoBehaviour {

	public Dialogue Dmanager;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			AudioManager.Playclip("Jhin");
			string[] dialogue = { "Zed: Finally I found you Jhin…", "Jhin: Come to me to be count with your dead family Zed.",
			"Zed: YOU WILL REGRET WHAT YOU HAVE DONE...."};


			Dmanager.SetSentences(dialogue);
			Dmanager.StartCoroutine(Dmanager.TypeDialogue());
		}
		Destroy(gameObject);
	}
}
