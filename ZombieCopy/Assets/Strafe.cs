using UnityEngine;
using System.Collections;

public class Strafe : MonoBehaviour {
	 public Transform player;
	void Update() {
		if (Input.GetButton("q"))
			player.Translate(.25f,0,0);
		
		         if (Input.GetButton("e"))
			player.Translate(-.25f,0,0);
	}
}

