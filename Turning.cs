using UnityEngine;
using System.Collections;

public class Turning : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
			this.transform.RotateAround (GameObject.Find ("Player").transform.position,
		                            Vector3.up, 180 * Time.deltaTime);
	}
}
