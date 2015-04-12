using UnityEngine;
using System.Collections;

public class HarpoonMover : MonoBehaviour {
	Vector3 Place;
	public GameObject world;
	Quaternion Tilt;
	bool goBack = false;
	bool goForward = true;
	bool pullForward = false;
	GameObject Asteroid;
	moveForward moveScript;
	// Use this for initialization
	void Start () {
		Place = this.transform.position;
		Tilt = this.transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		if (goBack) {
						this.gameObject.transform.parent = null;
						
						this.transform.position = Vector3.MoveTowards (this.transform.position, Place, .075f);
						if (this.transform.position == Place) {
								goBack = false;
								//this.gameObject.tag = ("Untagged");
						}
				} else if (goForward) {
						this.transform.position = Vector3.MoveTowards (this.transform.position, Place, 5f);
						if (this.transform.position == Place) {
								goForward = false;
								Hooked ();
								pullForward = true;
				moveScript = world.GetComponent("moveForward") as moveForward;
				moveScript.speed = 0;
						}
				} else if (pullForward) {
			world.transform.position = Vector3.MoveTowards (world.transform.position, Place, 5f);
			print ("movingToASteroid");

			if(world.transform.position == Place) {
				pullForward = false;
			}
				}
	}

	internal void Hooked()
	{
		if (Asteroid != null) {
						Asteroid.tag = ("Hooked");
				}
		}

	internal void SendForward(Vector3 place, GameObject asteroid){
		this.transform.parent = null;
		if(Asteroid != null){Asteroid.tag = ("NotHooked");}
		Asteroid = asteroid;
		goForward = true;
		Place = place;
		}
	internal void SendBack(){

		this.transform.rotation = Tilt;
		goBack = true;
	//	if (Grabber != null) {
	//					DialStarter og = Grabber.GetComponent ("DialStarter") as DialStarter;
	//					og.UnHook ();
	//			}
	}

//	internal Vector3 GetOriginalPosition(){
//		print (Place);
//		return(Place);
//		}
//	internal Quaternion GetOriginalRotation(){
//		return Tilt;}
}
