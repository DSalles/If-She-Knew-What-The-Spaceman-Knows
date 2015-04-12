using UnityEngine;
using System.Collections;

public class moveForward : MonoBehaviour {
	public int speed = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate(Vector3.forward * Time.deltaTime* speed);
	}
}
