using UnityEngine;
using System.Collections;

public class FlySpawnScript : MonoBehaviour {
	private Vector3 temp;
	private Camera[] cameras;
	private Camera mainCam;

	// Use this for initialization
	void Start () {
		temp = UnityEngine.Random.insideUnitSphere * 5;
		cameras = Camera.allCameras;
		foreach (Camera camera in cameras) {
						if (camera.name == "Main Camera") {
								mainCam = camera;
						}
				}

		transform.position = mainCam.transform.position;
		transform.position += temp;
		//transform.position = Camera.main.transform.position;// + UnityEngine.Random.insideUnitSphere * 5;
	}


}
