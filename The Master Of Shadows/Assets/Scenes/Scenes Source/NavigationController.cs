using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationController : MonoBehaviour {

	public void GoToIntroVideo()
    {
		Application.LoadLevel(0);
    }

	public void GoToMainMenu()  
	{
		Application.LoadLevel(1);
	}

	public void GoToLevel1()
	{
		Application.LoadLevel(2);
	}

	public void GoToLevel2()
	{
		Application.LoadLevel(3);
	}

	public void GoToLevel3()
	{
		Application.LoadLevel(4);
	}

	public void GoToLevel4()
	{
		Application.LoadLevel(6);
	}

	public void GoToGameOver1()
	{
		Application.LoadLevel(7);
	}
	public void GoToGameOver2()
	{
		Application.LoadLevel(8);
	}
	public void GoToGameOver3()
	{
		Application.LoadLevel(9);
	}
	public void GoToGameOver4()
	{
		Application.LoadLevel(10);
	}
	public void GoToEndScene()
	{
		Application.LoadLevel(11);
	}

	public void Quit()
    {
		Application.Quit();

	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
