using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kusho_Dialogue : MonoBehaviour {
	public Dialogue Dmanager;

	void Start () {
		
	}
	
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other)
    {
		if (other.tag == "Player")
        {
			string[] dialogue = { "Kusho: Hello Zed", "Kusho: Today you will remember how to fight",
				"Kusho: but first you must know how to jump", "Kusho: To jump press on Space button", 
				"Kusho: And to fight press on Q button", "Kusho: To throw Kunai you must first collect one then press on W button",
				"Kusho: And you have 4 Lives so, keep focus",
				"Kusho: That's all instructions you need for now....", "Zed: Thank you, my master" };
			// index from 0 to 7 due to size of texts is 8

			Dmanager.SetSentences(dialogue);
			Dmanager.StartCoroutine(Dmanager.TypeDialogue());
        }
    }
}
