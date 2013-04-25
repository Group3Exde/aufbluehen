using UnityEngine;
using System.Collections;

public class FlowerController : MonoBehaviour {
	
	public Transform target;
	bool IsGrowing = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionEnter(Collision collision) {//pong is growing on collision
		if(IsGrowing)
		{
			this.transform.localScale = new Vector3(this.transform.localScale.x, this.transform.localScale.y+1.5f, this.transform.localScale.z);
			GameObject pong = GameObject.Find("Pong");
			pong.transform.localScale = new Vector3(pong.transform.localScale.x*1.3f, pong.transform.localScale.y, pong.transform.localScale.z);
			IsGrowing = false;
		}
	}
}
