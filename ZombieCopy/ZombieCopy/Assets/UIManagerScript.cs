using UnityEngine;
using System.Collections;

public class UIManagerScript : MonoBehaviour {
	

	void Start()
	{
		Screen.showCursor = true;		
	}

	public void StartGame()
	{
		Application.LoadLevel("SurviveTheNight");
	}

	public void QuitGame()
	{
		Application.Quit ();
	}



}

