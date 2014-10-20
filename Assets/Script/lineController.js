#pragma strict

public var lineObject : GameObject;
function Update () {
    if (Input.GetMouseButtonDown(0)) {
        Instantiate(lineObject, transform.position, transform.rotation);
    }
}