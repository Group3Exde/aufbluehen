using UnityEngine;
using System.Collections;

public class FloorCollision : MonoBehaviour {
	bool colide = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision col){
		if(col.gameObject.name == "Sphere"){
		colide = true;
		}
	}
	void OnGUI(){
		if(colide){
			Screen.showCursor = true;
			GUI.Box(new Rect(Screen.width/2, Screen.height/2,100,50), "GAME OVER");
			if(GUI.Button(new Rect(Screen.width/2, Screen.height/2+20,100,30), "RESTART")) {
				Application.LoadLevel (0); 
			}
			GameObject sphere = GameObject.Find("Sphere");
			if(sphere != null) GameObject.Destroy(sphere);
			GameObject pong = GameObject.Find ("Pong");
			if(pong != null)  GameObject.Destroy(pong);
		}
	}
}
