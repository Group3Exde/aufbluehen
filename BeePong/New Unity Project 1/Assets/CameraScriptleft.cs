using UnityEngine;
using System.Collections;

public class CameraScriptleft : MonoBehaviour {
	
	public Transform target;
	public float smooth = 2;
	private bool moveCamera = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		/*Vector3 camPos = transform.position;
		Debug.Log ("campos " + this.camera.rect.width);
		Debug.Log("target local " + target.transform.localPosition.x);
		if(Mathf.Abs(target.transform.localPosition.x) > 22) {
			camPos.x += 10;
		}
		this.transform.position = camPos;
		*/
		if(moveCamera) {
			Vector3 camPos = transform.parent.position;
			this.transform.parent.Translate((Time.deltaTime*target.rigidbody.velocity.x)-0.03f, 0, 0);
			//Debug.Log(transform.parent.position.x - target.position.x);
			if(transform.parent.position.x - target.position.x > -0.7 && transform.parent.position.x - target.position.x < 0.7) {
				
				moveCamera = false;
			}
		}
			
	}
	void OnTriggerEnter(Collider other) {
		//Debug.Log("Collided");

		//Debug.Log (transform.parent.name);
		//this.transform.parent.position = new Vector3(Mathf.Lerp(camPos.x,target.position.x+50, Time.deltaTime*smooth), transform.parent.position.y, transform.parent.position.z);
		if(other.name.Equals("Sphere")) {
			moveCamera = true;
		}
		
	}
	
	void onTriggerExit(Collider other) {
		moveCamera = false;
	}
	
}
