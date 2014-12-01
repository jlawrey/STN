using UnityEngine;
using System.Collections;

public class JM_MainMenuScript : MonoBehaviour 
{
	public bool isQuit = false; //Only check true on the exit button, true means that button leaves the game

	void OnMouseDown()
	{
		if (isQuit) 
		{
			Application.Quit();
		}
		else
		{
			Application.LoadLevel ("SurviveTheNight");
		}
	}
}
