﻿using UnityEngine;
using System.Collections;

public class playerControl : MonoBehaviour 
{
	[SerializeField] Transform leftPunchButton;
	[SerializeField] Transform rightPunchButton;
	[SerializeField] int speed;
	
	
	void Update (){
		for(int i = 0; i < Input.touchCount; i++){
			if(leftPunchButton.guiTexture.HitTest(Input.GetTouch(i).position)){
				Debug.Log("punch left");
			}
			else if(rightPunchButton.guiTexture.HitTest(Input.GetTouch(i).position)){
				Debug.Log("punch right");
			}
			else{
				transform.LookAt(Input.GetTouch(i).position);
				rigidbody2D.velocity = new Vector2(speed,0);
			}
		}
	}
}