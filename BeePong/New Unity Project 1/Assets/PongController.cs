using UnityEngine;
using System.Collections;

public class PongController : MonoBehaviour {
	
	private Vector3 beeOriginVelocity;
	private bool istVelocityStored = false;

	// Use this for initialization
	void Start () {		
		Screen.showCursor = false;
	}
	
	// Update is called once per frame
	void Update () {		
		Vector3 pos = new Vector3();
		pos.x = Camera.main.ScreenToWorldPoint(Input.mousePosition).x ;
		this.transform.position = new Vector3(pos.x,this.transform.position.y,this.transform.position.z);
		
	}
	
    void OnCollisionEnter(Collision collision) {
		float velocity = collision.rigidbody.velocity.magnitude;
		Vector3 colVelocity = collision.rigidbody.velocity;
		colVelocity.x = (collision.transform.position.x -transform.position.x);
		if(!istVelocityStored) {
			beeOriginVelocity = GameObject.Find("Sphere").transform.rigidbody.velocity;
			istVelocityStored = true;
		}
		colVelocity.y = beeOriginVelocity.y * 0.3f;
		Debug.Log(colVelocity);
		collision.rigidbody.velocity = colVelocity;
		if (collision.rigidbody.velocity.magnitude < velocity) {
			collision.rigidbody.velocity *= velocity/collision.rigidbody.velocity.magnitude;
		}
	}
}