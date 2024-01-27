using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fromLvl_3to4 : MonoBehaviour {

	private void OnTriggerEnter2D(Collider2D other)
	{
		SceneManager.LoadScene(5);
	}
}
