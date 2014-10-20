using UnityEngine;
using System.Collections;

public class LineTest : MonoBehaviour {
	
		
		public Transform[] transforms;
		LineRenderer lineRenderer;
		
		// Use this for initialization
		void Awake () {
			lineRenderer = GetComponent<LineRenderer>();
			lineRenderer.SetVertexCount(transforms.Length);
		}
		
		// Update is called once per frame
		void Update () {
			for(int i=0; i<transforms.Length;i++){
				lineRenderer.SetPosition(i, transforms[i].position);
			}
		}

}
