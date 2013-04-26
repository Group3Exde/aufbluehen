using UnityEngine;
using System.Collections;

public class GameTimer : MonoBehaviour {
	public float timer = 60;
	private int gettime;
	private string neu;
	bool isover = false;
	
	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void Update () {
     
		timer -= Time.deltaTime;
		int gettime = Mathf.CeilToInt(timer);
		neu = gettime.ToString();
		
	
	if(gettime % 6 == 0){
		float newscale_size = transform.localScale.x - 0.01f;
		transform.localScale = new Vector3(newscale_size,transform.localScale.y,transform.localScale.z);
		//Debug.Log(newscale_size);
			if(transform.localScale.x < 4){
				isover = true;
			}
		}
		
	}
	void OnGUI(){
		GUI.Box(new Rect(2,5,200,50),"Timer: " + neu);
	}
}
