using UnityEngine;
using System.Collections;

public class FixedLineRenderer : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {
		GameObject cube_1 = GameObject.Find("Cube1");
		GameObject cube_2 = GameObject.Find("Cube2");
		LineRenderer lineY = GameObject.Find ("LineRendererObject").GetComponent<LineRenderer> ();
		
		lineY.SetPosition(0, cube_1.transform.position);
		lineY.SetPosition(1, cube_2.transform.position);
	}
}
