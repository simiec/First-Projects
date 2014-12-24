using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		ViewCamera ();
		Debug.Log (GameObject.Find ("Player").transform.position.x);

	}
	void ViewCamera(){

				this.transform.position = new Vector3 (GameObject.Find ("Player").
                  transform.position.x + 11, GameObject.Find ("Player").transform.position.y - 3, -10);


		}
}
