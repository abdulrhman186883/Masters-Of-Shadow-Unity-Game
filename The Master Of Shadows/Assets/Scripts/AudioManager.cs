using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
	public static AudioClip hitSound, jumpSound, deathSound, killing_boss, Killing_Kusho, taking_shadowbox, Zed_Hit, Jhin_Voice;
	static AudioSource audioSrc;

	// Use this for initialization
	void Start()
	{
		hitSound = Resources.Load<AudioClip>("First hit");
		jumpSound = Resources.Load<AudioClip>("Jump");
		deathSound = Resources.Load<AudioClip>("Die with edit");
		killing_boss = Resources.Load<AudioClip>("After killing any boss");
		Killing_Kusho = Resources.Load<AudioClip>("After killing kusho");
		taking_shadowbox = Resources.Load<AudioClip>("After taking the shadow box");
		Zed_Hit = Resources.Load<AudioClip>("ZedHit");
		Jhin_Voice = Resources.Load<AudioClip>("Jhin");
		
		audioSrc = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update()
	{

	}
	public static void Playclip(string clip)
	{
		switch (clip)
		{
			case "First hit":
				audioSrc.PlayOneShot(hitSound);
				break;
			case "Jump":
				audioSrc.PlayOneShot(jumpSound);
				break;
			case "death":
				audioSrc.PlayOneShot(deathSound);
				break;
			case "KillingBoss":
				audioSrc.PlayOneShot(killing_boss);
				break;
			case "KillingKusho":
				audioSrc.PlayOneShot(Killing_Kusho);
				break;
			case "TakingShadowbox":
				audioSrc.PlayOneShot(taking_shadowbox);
				break;
			case "ZedHit":
				audioSrc.PlayOneShot(Zed_Hit);
				break;
			case "Jhin":
				audioSrc.PlayOneShot(Jhin_Voice);
				break;

		}
	}
}
