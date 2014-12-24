using UnityEngine;
using System.Collections;

public class EndlessTerrain : MonoBehaviour {

	public BoxCollider2D bc;
	bool crot = false;
	bool crot2 = true;

	// Use this for initialization
	void Start () {
	
		GameObject plane = GameObject.CreatePrimitive (PrimitiveType.Plane);
		plane.transform.position = new Vector3 (0, -3.3f, 0);
		plane.transform.rotation = Quaternion.Euler (270, 0, 0);
		plane.transform.localScale = new Vector3 (3, 1, .5f);
		bc = plane.AddComponent("BoxCollider2D") as BoxCollider2D;
		plane.name = "plane";
	}
	
	// Update is called once per frame
	void Update () {
		if (crot2 == true) {
						if (GameObject.Find ("Player").transform.position.x >= GameObject.Find ("plane").transform.position.x -10
								&& crot == false) {
								
								Destroy(GameObject.Find("plane1"));
								GameObject plane1 = GameObject.CreatePrimitive (PrimitiveType.Plane);
								plane1.transform.position = new Vector3 (GameObject.Find ("plane").transform.position.x + 30,
			                                        GameObject.Find ("plane").transform.position.y,
			                                        GameObject.Find ("plane").transform.position.z);
								plane1.transform.rotation = Quaternion.Euler (270, 0, 0);
								plane1.transform.localScale = new Vector3 (3, 1, .5f);
								plane1.name = "plane1";
								crot = true;
								crot2 = false;
						}
				}
		if(crot == true){
						if (GameObject.Find ("Player").transform.position.x >= GameObject.Find ("plane1").transform.position.x -10
								&& crot2 == false) {
								
								Destroy (GameObject.Find ("plane"));
								GameObject plane = GameObject.CreatePrimitive (PrimitiveType.Plane);
								plane.transform.position = new Vector3(GameObject.Find ("plane1").transform.position.x +30,
				                                        GameObject.Find ("plane1").transform.position.y,
				                                        GameObject.Find ("plane1").transform.position.z);
								plane.transform.rotation = Quaternion.Euler (270, 0, 0);
								plane.transform.localScale = new Vector3 (3, 1, .5f);
								plane.name = "plane";
								crot2 = true;
								crot = false;
						}
				}
	}
}
