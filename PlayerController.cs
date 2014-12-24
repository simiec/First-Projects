using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {


	public float fspeed;
	Vector3 v3NextPos;
	bool wallTemas = false;
	bool zeminTemas = false;
	Vector3 deneme;
	


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Walk ();
		this.transform.rotation = Quaternion.identity;

		GameObject.Find ("Box001").transform.localPosition =  deneme;

		Debug.Log (deneme);


	}

	void Walk(){

//Sağa Gitme		*****	

				if (Input.GetKey (KeyCode.RightArrow)) {

						v3NextPos.x = this.transform.position.x + fspeed;
						v3NextPos.y = this.transform.position.y;
						v3NextPos.z = this.transform.position.z;
						this.transform.position = v3NextPos;
						this.transform.rotation = Quaternion.identity;
				}

//Sola gitme		*****	

				if (Input.GetKey (KeyCode.LeftArrow)) {
			
						v3NextPos.x = this.transform.position.x - fspeed;
						v3NextPos.y = this.transform.position.y;
						v3NextPos.z = this.transform.position.z;
						this.transform.position = v3NextPos;
						this.transform.rotation = Quaternion.identity;
				}

//Yukarı gitme		*****

				if (Input.GetKey (KeyCode.UpArrow)) {
						
						v3NextPos.x = this.transform.position.x;
						v3NextPos.y = this.transform.position.y;
						v3NextPos.z = this.transform.position.z + fspeed;
						this.transform.position = v3NextPos;
						this.transform.rotation = Quaternion.identity;						
				}

//Aşağı gitme 		*****

				if (Input.GetKey (KeyCode.DownArrow)) {
						
						v3NextPos.x = this.transform.position.x;
						v3NextPos.y = this.transform.position.y;
						v3NextPos.z = this.transform.position.z - fspeed;
						this.transform.position = v3NextPos;
						this.transform.rotation = Quaternion.identity;
				}

//Kilitleme 		*****
	
				
}

	void OnCollisionEnter(Collision col){

		if (col.gameObject.tag == "Wall") {

			wallTemas = true;
		}

		if (col.gameObject.tag == "Zemin") {

			zeminTemas = true;
		}
	}

	void OnCollisionExit(Collision col){

		if (col.gameObject.tag == "Wall") {

			wallTemas = false; 
		}

		if (col.gameObject.tag == "Zemin") {

			zeminTemas = false;
		}
	}

	void MovementCamera(){





	}
}







