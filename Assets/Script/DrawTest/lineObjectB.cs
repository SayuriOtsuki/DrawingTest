using UnityEngine;
using System.Collections;

public class lineObjectB: MonoBehaviour {

	float deltaTime = 0.0f;
	public float touchInterval = 0.001f;
	bool touchEnable = true;
	LineRenderer lineRenderer;
	int lineIndex = 1;
	bool controll = true;
	private Vector3 screenPoint;
	private Vector3 worldPoint;
	public GameObject Prefab;

	// Use this for initialization
	void Start () {
		lineRenderer = GetComponent<LineRenderer>();
		Debug.Log(lineRenderer);
		lineRenderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
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

	void touch() {
		screenPoint = Input.mousePosition;
		screenPoint.z = 10.0f;
		Debug.Log ("screenPoint=" + screenPoint);
		//Instantiate(Prefab, Camera.main.ScreenToWorldPoint(screenPoint), Prefab.transform.rotation);

		worldPoint = Camera.main.ScreenToWorldPoint(screenPoint);
		Debug.Log(worldPoint);
		lineRenderer.enabled = true;
		lineRenderer.SetVertexCount(lineIndex);
		lineRenderer.SetPosition(lineIndex-1, worldPoint);
		lineIndex++;
	}
}
