using UnityEngine;
using System.Collections;

public class GameTimer : MonoBehaviour {
	public float timer;
	public int interval = 3;
	private int gettime;
	private string lifetime;
	bool isover = false;
	GameObject floor;
	GameObject beehive;
	// Use this for initialization
	void Start () {
		
	timer = 60;
		
	floor = GameObject.Find("Floor");
	
	
	}
	
	// Update is called once per frame
	void Update () {
		
    FloorCollision floorcol = floor.GetComponent<FloorCollision>(); 
		
		if(gettime >= 0 && !floorcol.colidee){
		timer -= Time.deltaTime;
		gettime = Mathf.CeilToInt(timer);
		lifetime = gettime.ToString();
		}
		else {
			isover = true;
			lifetime = "0";
		}
		
	
	if(gettime % interval == 0){
		float newscale_size = transform.localScale.x - 0.01f;
		if(newscale_size > 0) {
			transform.localScale = new Vector3(newscale_size,transform.localScale.y,transform.localScale.z);
				if(newscale_size < 4){
					renderer.material.color = Color.red;
				}
				else{
					renderer.material.color = Color.green;
				}
		}
		}
		
	}
	void OnGUI(){
		
		GUI.Box(new Rect(2,5,200,50),"Timer: " + lifetime );
		if(isover){
		GUI.Box(new Rect(Screen.width/2, Screen.height/2,200, 50), "GAME OVER");
		GameObject sphere = GameObject.Find("Sphere");
		if(sphere != null) GameObject.Destroy(sphere);
		}
	}
}
