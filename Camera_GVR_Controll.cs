using UnityEngine;
using System.Collections;

public class Camera_GVR_Controll : MonoBehaviour {
	public GameObject stop;

	bool isWalking=false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (isWalking) {
			transform.root.position = transform.root.position + Camera.main.transform.forward * .5f * Time.deltaTime;
		
				}


		Ray ray = Camera.main.ViewportPointToRay (new Vector3 (.5f, .5f, 0));
		RaycastHit hit;

		if (Physics.Raycast (ray, out hit)) {
		
			if (hit.collider.name.Contains ("stop")) {
				isWalking = false;
			
			} else
				isWalking = true;
		}
	}
}
