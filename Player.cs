using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float fSpeed;
	public float fJumpSpeed;
	public float fDownSpeed;
	Vector3 v3NextPos;
	static bool temas= false;
	bool parlıyor = false;
	bool doubleJump= false;
	float sifirNoktasi;
	float fsayac = 0;
	float ftime = 0;




	void Start () {
	
		this.particleSystem.enableEmission = false;
	
	}
	void Update () {
		CameraView();
		Shine();
		Walk();
		this.transform.rotation = Quaternion.identity;


	

	}
	void Walk(){

		fsayac = this.transform.position.y - sifirNoktasi;

		//Sağa gitme	***
				if (Input.GetKey (KeyCode.D)) {
			
						v3NextPos.x = this.transform.position.x + fSpeed;
						v3NextPos.y = this.transform.position.y;
						v3NextPos.z = 0;
						this.transform.position = v3NextPos;
						this.transform.rotation = Quaternion.identity;
				}

		//Sola gitme	***
				if (Input.GetKey (KeyCode.A)) {
			
						v3NextPos.x = this.transform.position.x - fSpeed;
						v3NextPos.y = this.transform.position.y;
						v3NextPos.z = 0;
						this.transform.position = v3NextPos;
						this.transform.rotation = Quaternion.identity;
				}
				
		//Zıplama		***		
				if (Input.GetKeyDown (KeyCode.W)) {
						if (temas == true) {
								rigidbody.AddForce (transform.up * fJumpSpeed, ForceMode.Impulse);
								this.transform.rotation = Quaternion.identity;
								doubleJump = true;
								}
							} 
								
				if(doubleJump== true && fsayac>=1){
						if (Input.GetKeyDown (KeyCode.W)) {
								rigidbody.AddForce (transform.up * fJumpSpeed, ForceMode.Impulse);
								this.transform.rotation = Quaternion.identity;
								doubleJump = false;	
								fsayac=0;
												
						}
				}	
		//Dikey iniş	***
				if(Input.GetKey(KeyCode.S)){
					rigidbody.AddForce(transform.up * fDownSpeed, ForceMode.Impulse);
			}
		}

	void Shine(){

		ftime += Time.deltaTime;

		if (parlıyor == false && ftime >=1) {
						if (Input.GetKey (KeyCode.F)) {
								this.particleSystem.enableEmission = true;
								parlıyor = true;
								ftime=0;
						}
				}
		if (parlıyor == true && ftime >=1){
						if (Input.GetKey (KeyCode.F)) {
							this.particleSystem.enableEmission= false;
							parlıyor = false;
							ftime=0;
						}
				}	
	}
	void OnCollisionEnter(Collision col){

		if (col.gameObject.name == "Platform") {
				temas = true;
				sifirNoktasi = this.transform.position.y;
				doubleJump = false;				
			}
		}
	void OnCollisionExit(Collision col){
		
		if(col.gameObject.name == "Platform"){
				temas = false;
			}
		}
	void CameraView(){

		if (temas == true) {

			GameObject.Find("Main Camera").transform.position = new Vector3(
				this.transform.position.x + 11, sifirNoktasi - 3, -10);
			
		}
	}
}
	


	
	
