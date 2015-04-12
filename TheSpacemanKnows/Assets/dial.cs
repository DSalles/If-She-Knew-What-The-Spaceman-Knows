using UnityEngine;
using System.Collections;

public class dial : MonoBehaviour {
	public Material circleShader;
	public Texture[] circleAnimation = new Texture[13];
	public GameObject harpoon;
	bool playing = false;
	int i = 0;

	DialStarter Grabber;
	// Use this for initialization
	void Start () {
		circleShader.SetTexture (0, circleAnimation [0]);
	}
	
	// Update is called once per frame
	void Update () {
				


		}
	internal void StopAnim() {

	//	print ("StopANim");
		circleShader.SetTexture (0, circleAnimation [0]);
		i = 0;

		}

	internal void PlayAnim(DialStarter og){
	if (i < 49) {
						circleShader.SetTexture (0, circleAnimation [(int)(i / 4)]);
						i++;
				} else {
			circleShader.SetTexture (0, circleAnimation [circleAnimation.Length-1]);
						og.SendHarpoon (harpoon);
				}

		//print ("PlayAnim");

		}

}
