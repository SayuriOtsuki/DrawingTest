using UnityEngine;
using System.Collections;

public class lineController : MonoBehaviour {

	public GameObject lineObject;

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			Instantiate(lineObject, transform.position, transform.rotation);
		}
	}
}
