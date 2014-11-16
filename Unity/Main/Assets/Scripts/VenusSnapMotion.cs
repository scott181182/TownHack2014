using UnityEngine;
using System.Collections;

public class VenusSnapMotion : MonoBehaviour {

	double recoilSpeed = 0.01;    // Speed to move camera

	// Use this for initialization
	void Start () {
	
	}
	/*
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")){
			snap();
		}
	}

	void MoveToPosition(Vector3 newPosition , double time){
		double elapsedTime = 0;
		double startingPos = transform.position;
		
		while (elapsedTime < time){
			transform.position = Vector3.Lerp(startingPos, newPosition, (elapsedTime / time));
			elapsedTime += Time.deltaTime;
			yield return null;
		}
	}

	void snap(){
		Vector3 zoomOutOffset = Vector3(0, 0, 0.5);
		Vector3 zoomOutWorldPosition = transform.TransformDirection( zoomOutOffset );
		// Move the camera smoothly 
		StartCoroutine(MoveToPosition(transform.position + zoomOutWorldPosition, recoilSpeed));             
	}
*/
}
