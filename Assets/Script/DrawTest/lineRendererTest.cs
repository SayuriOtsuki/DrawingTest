using UnityEngine;
using System.Collections;

public class lineRendererTest : MonoBehaviour {
	
	public Color c1 = Color.yellow;
	public Color c2 = Color.red;
	public int lengthOfLineRenderer = 20;
	void Start() {
		LineRenderer lineRenderer = gameObject.GetComponent<LineRenderer>();
		lineRenderer.material = new Material(Shader.Find("Particles/Additive"));
		lineRenderer.SetColors(c1, c2);
		lineRenderer.SetWidth(0.2F, 0.2F);
		lineRenderer.SetVertexCount(lengthOfLineRenderer);
	}
	void Update() {
		LineRenderer lineRenderer = GetComponent<LineRenderer>();

		int index = 0;
		while (index < lengthOfLineRenderer) {
		 	Debug.Log ("index =" + index);
			Vector3 pos = new Vector3(index * 0.5f, Mathf.Sin(index + Time.time), 0);
			lineRenderer.SetPosition(index, pos);
			index++;
		}

		/*int index;
		for (index = 0; index < 20; index++) {
			Debug.Log ("index =" + index);
			Vector3 pos = new Vector3(index * 0.5f, Mathf.Sin(index + Time.time), 0);
			lineRenderer.SetPosition(index, pos);
		}*/
	}
}
