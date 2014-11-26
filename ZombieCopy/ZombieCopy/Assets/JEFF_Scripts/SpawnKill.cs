using UnityEngine;
using System.Collections;

public class SpawnKill : MonoBehaviour {





	
	// Update is called once per frame
	void Update () 
	{
		Destroy (this.gameObject, 10f);
	}
}
