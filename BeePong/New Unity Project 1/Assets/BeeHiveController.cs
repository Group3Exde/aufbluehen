using UnityEngine;
using System.Collections;

public class BeeHiveController : MonoBehaviour {
	public bool colide = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter(Collision col) {//pong is growing on collision
		if(col.gameObject.name == "Sphere"){
			colide = true;
		}
	}
	
	void OnGUI(){
		if(colide){
			GUI.Box(new Rect(Screen.width/2, Screen.height/2,200,50), "FINISHED!");
			GameObject sphere = GameObject.Find("Sphere");
			if(sphere != null) GameObject.Destroy(sphere);	
		}
	}
}
