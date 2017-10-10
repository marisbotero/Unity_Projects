using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonControler : MonoBehaviour {

	// how much it grows each time
	public float scaleFactor = 1.2f;


	//maxium scale
	public float maxScale = 3;

	// Use this for initialization
	
	//Method that will detete mouse press

	void Star(){

		if (scaleFactor <=1){
			print("It's too small");
		}

	}

	void OnMouseDown(){
		//increase the scale 
		//transform.localScale = transform.localScale * scaleFactor;
		transform.localScale *= scaleFactor;	

	    //increase this value

		//check if we've passed the maxS
		if (transform.localScale.x >= maxScale){
			//if so, we want to destroy the ballon
			Destroy(gameObject);
		}


	}
	
}
