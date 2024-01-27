using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvl2_Shen_Dialogue : MonoBehaviour {
	public Dialogue Dmanager;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			string[] dialogue = { "Shen: This is the place, we arrived, we only need to find where he is hiding !!",
			"Zed: do not worry I will find him whatever it takes from me.","Shen: take care on your way."};


			Dmanager.SetSentences(dialogue);
			Dmanager.StartCoroutine(Dmanager.TypeDialogue());
		}
	}
}
