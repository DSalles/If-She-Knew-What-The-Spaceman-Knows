using UnityEngine;
using System.Collections;

// this belongs to the asteroid and tells dials to start or stop and harpoon to start moving

public class DialStarter : MonoBehaviour {
	public GameObject dialQuad;
	dial DialScript;
	// Use this for initialization

	void Start () {
		DialScript = dialQuad.GetComponent("dial") as dial;
		this.gameObject.tag = ("NotHooked");
	}
	void OnGazeHold(){
		if(this.gameObject.tag == ("NotHooked")){
			DialScript.PlayAnim (this);}
		}

	void OnGazeExit(){
		DialScript.StopAnim ();
		}

	internal void SendHarpoon(GameObject harpoon){
		if (this.gameObject.tag == ("NotHooked")) {

			HarpoonMover hm = harpoon.GetComponent ("HarpoonMover")as HarpoonMover;
				hm.SendForward (this.transform.position, this.gameObject);

				
						//this.gameObject.tag = ("Hooked");
				}
		}

	internal void UnHook(){
		}

	// Update is called once per frame
	void Update () {
	
	}
}
