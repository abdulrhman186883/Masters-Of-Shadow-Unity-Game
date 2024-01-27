using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvl2_1_Kusho_Dialogue : MonoBehaviour {

	public Dialogue Dmanager;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			string[] dialogue = { "Kusho: Take care Zed, Jhin is not an easy guy, he is too dangerous.",
				"Zed: I know my master. But I was preparing all my life to reach this day","Kusho: I know, now go and find him."};


			Dmanager.SetSentences(dialogue);
			Dmanager.StartCoroutine(Dmanager.TypeDialogue());
		}
	}
}
