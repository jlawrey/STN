using UnityEngine;
using System.Collections;

public class SpawnKill4: MonoBehaviour {





	
	// Update is called once per frame
	void Update () 
	{
		Destroy (this.gameObject, 90f);
	}
}
