using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvl3_1_Zed_Dialogue : MonoBehaviour {

	public Dialogue Dmanager;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			string[] dialogue = { "Zed: Now, I must find the box key. To get the Dark Shadow...",
				"Zed: The key will be here in the dark forest and it must be guarded.",
				"Zed: But no problem I will deal with any monster"};


			Dmanager.SetSentences(dialogue);
			Dmanager.StartCoroutine(Dmanager.TypeDialogue());
		}
		Destroy(gameObject);
	}
}
