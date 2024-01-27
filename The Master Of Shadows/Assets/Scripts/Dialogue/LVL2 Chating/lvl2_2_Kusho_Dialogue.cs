using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvl2_2_Kusho_Dialogue : MonoBehaviour {

	public Dialogue Dmanager;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			string[] dialogue = { "Kusho: IT IS ENOUGH ZED!! LEAVE HIM ALIVE.",
				"Zed: I WILL KILL HIM, I WILL NOT LEAVE HIM ALIVE!!","Kusho: IT IS AN ORDER!! LEAVE HIM ALONE.",
				"Zed: I WANT TO TAKE MY REVENGE…","Kusho: I SAID ENOUGH..","Zed: ROARRRR !!!!"};


			Dmanager.SetSentences(dialogue);
			Dmanager.StartCoroutine(Dmanager.TypeDialogue());
		}
	}
}
