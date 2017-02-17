# vrGame
virtual reality

Action Scripts virtual reality glasses specs make moves when you look forward and look at the bottom of the stand

use
=========================
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
   move the Camera forward
   if u'd see 
   https://www.youtube.com/watch?v=wPwgyE6x2K8
