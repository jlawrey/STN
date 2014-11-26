﻿
using UnityEngine;
using System.Collections;

public class Aim_v2 : MonoBehaviour {

public Texture2D cursorImage;
private int cursorWidth = 32;
private int cursorHeight = 32;
private Transform myTransform;
private Camera myCamera;		
		
	void Start() {
		
		
			myCamera = GameObject.FindWithTag("MainCamera").GetComponent<Camera> ();
			myTransform = transform;    //So you don't GetComponent your transform with every OnGUI call
			

			
		Screen.showCursor = false;
		
		
				}			
			
	void OnGUI() {
		
		

			Vector3 screenPos = myCamera.WorldToScreenPoint(myTransform.position);
		
			screenPos.y = Screen.height - screenPos.y; //The y coordinate on screenPos is inverted so we need to set it straight
		
			GUI.DrawTexture(new Rect(screenPos.x, screenPos.y, cursorWidth, cursorHeight), cursorImage);
		
				}
	
	
}



