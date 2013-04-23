using UnityEngine;
using System.Collections;

public class PongController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = new Vector3();
		pos.x = Camera.main.ScreenToWorldPoint(Input.mousePosition).x ;
		pos.x = (Input.mousePosition).x;
		Debug.Log ("posx: " + pos.x);
		//pos.x = Mathf.Clamp( transform.position.x, -14, 14);
		this.transform.position = new Vector3(pos.x,this.transform.position.y,this.transform.position.z);
	}
	
    void OnCollisionEnter(Collision collision) {
		float velocity = collision.rigidbody.velocity.magnitude;
		Vector3 colVelocity = collision.rigidbody.velocity;
		colVelocity.x = (collision.transform.position.x -transform.position.x);
		collision.rigidbody.velocity = colVelocity;
		if (collision.rigidbody.velocity.magnitude < velocity) {
			collision.rigidbody.velocity *= velocity/collision.rigidbody.velocity.magnitude;
		}
	}
}