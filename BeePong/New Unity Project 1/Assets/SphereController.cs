using UnityEngine;
using System.Collections;

public class SphereController : MonoBehaviour {
	private float maxSphereHeight;
	// Use this for initialization
	void Start () {
		maxSphereHeight = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y > maxSphereHeight) {
			Debug.Log("reached max");
			this.rigidbody.velocity = new Vector3(rigidbody.velocity.x, rigidbody.velocity.y*0.2f, rigidbody.velocity.y);
		}
	
	}
}
