using UnityEngine;
using System.Collections;

public class ChangeColorOnGaze : MonoBehaviour {

	// Use this for initialization
	void Start () {	
	}

	void OnGazeHold()
	{
		if (this.gameObject.tag == ("NotHooked")) {
			this.renderer.material.color = Color.cyan;
				}
		}

	void OnGazeExit(){
		this.renderer.material.color = Color.gray;
		}

	//void onGazeDwellExit(){
	//	this.renderer.material.color = Color.gray;
	//}
	// Update is called once per frame
	void Update () {
		//this.renderer.material.color = Color.gray;
	}
}
