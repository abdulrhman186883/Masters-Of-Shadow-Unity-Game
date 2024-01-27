using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvl2_2_Zed_Dialogue : MonoBehaviour {

	public Dialogue Dmanager;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			string[] dialogue = { "Zed: NOW, THERE IS ONLY ONE WAY TO MAKE THEM PAYBACK TO ME… ",
			"Zed: THEY WILL REGRET THIS..."};


			Dmanager.SetSentences(dialogue);
			Dmanager.StartCoroutine(Dmanager.TypeDialogue());
		}
		Destroy(gameObject);
	}
}
