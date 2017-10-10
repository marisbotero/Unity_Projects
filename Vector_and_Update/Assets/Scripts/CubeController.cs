using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {


	public float speed = 0.1f;


	// Update is called once per frame
	void Update () {
		transform.position += speed * Vector3.up;
	

	// we want to our cube to move up and down between y=-10 and y=10
		if (transform.position.y >=10 && speed > 0){
			speed *= -1;

		}

		else if(transform.position.y <=-10 && speed <0){
			speed*=-1;
		}

	}
}
