#pragma strict

private var deltaTime : float = 0.0;
private var touchInterval : float = 0.05;
private var touchEnable = true;
public var lineObject : GameObject;
private var lineRenderer: LineRenderer;
private var lineIndex: int = 1;
private var controll = true;

function Start () {
    lineRenderer = GetComponent(LineRenderer);
    Debug.Log(lineRenderer);
    lineRenderer.enabled = false;
}
function Update () {
    if (Input.GetMouseButton(0) && touchEnable && controll) {
        touchEnable = false;
        touch();
    }
    if (Input.GetMouseButtonUp(0)) {
        controll = false;
    }
    deltaTime += Time.deltaTime;
    if (deltaTime > touchInterval) {
        deltaTime = 0;
        touchEnable = true;
    }
}
function touch() {
    var screenPoint = Input.mousePosition;
    screenPoint.z = 10.0;
    var worldPoint = camera.main.ScreenToWorldPoint(screenPoint);
    Debug.Log(worldPoint);
    lineRenderer.enabled = true;
    lineRenderer.SetVertexCount(lineIndex);
    lineRenderer.SetPosition(lineIndex-1, worldPoint);
    lineIndex++;
}