using UnityEngine;
using System.Collections;

public class CaughtFly : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	/*
	// Update is called once per frame
	void Update () {
		if (renderer.isVisible){
			Vector3 heading = this.position - Camera.main.transform.position;
			double distance = Vector3.Dot(heading,Camera.main.transform.forward);

			if (distance < 1.0){
				//destroy fly visible from main camera and less than 1 distance away
				DestroyObject(this);
			}
		}
	}*/
}
