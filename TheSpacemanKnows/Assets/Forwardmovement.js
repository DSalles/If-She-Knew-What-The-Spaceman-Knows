#pragma strict

function Start () {

}
public var speed : int = 1 ;
function Update () {
transform.Translate(Vector3.forward*Time.deltaTime*speed);

}