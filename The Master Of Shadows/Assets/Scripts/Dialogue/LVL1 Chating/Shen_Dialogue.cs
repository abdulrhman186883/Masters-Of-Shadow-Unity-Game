using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shen_Dialogue : MonoBehaviour {
	public Dialogue Dmanager;

	void Start()
	{

	}

	void Update()
	{

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			string[] dialogue = { "Shen: Well, done Zed.", "Zed: Thanks, I’m trying my best.", "Shen: I have good news for you.",
			"Zed: What is it ?!","Shen: We finally found Jhin’s place.",
			"Zed: That is great!! finally I’m going to take my revenge from the one who murdered my family….",
			"Shen: I hope so, let us go my friend."};
			

			Dmanager.SetSentences(dialogue);
			Dmanager.StartCoroutine(Dmanager.TypeDialogue());
		}
	}
}
