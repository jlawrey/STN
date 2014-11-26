using UnityEngine;
using System.Collections;

public class ThemeMusicPlay : MonoBehaviour {

	public AudioClip themeMusic;

	AudioSource playerAudio;
	// Use this for initialization
	void Awake () 
	{
		playerAudio = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		playerAudio.clip = themeMusic;
		playerAudio.Play ();
	}
}
