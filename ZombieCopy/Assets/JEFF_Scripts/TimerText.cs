using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimerText : MonoBehaviour
{
	public float restartDelay = 5f;
	public float startTime = 0f;
	public float endtime = 0f;
	
	Animator anim;
	Text text;
	float restartTimer;

//	void Awake()
//	{
//
//	}

	void Awake()
	{
		text = GetComponent <Text> ();
		anim = GetComponent<Animator>();

	}
	
	
	void Update ()
	{
		startTime -= Time.deltaTime;
		text.text = "TIME: " + startTime;

		if (startTime < endtime) 
		{
			anim.SetTrigger ("GameWin");
			text.text = "TIME: " + endtime;
			restartTimer += Time.deltaTime;

			if (restartTimer >= restartDelay) 
			{
				Application.LoadLevel ("SplashLoader");
			}
			
		

		}
	}
}
