using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		int x = 0;
		int y = 0;

		if (Input.GetKey(KeyCode.A)) {
			x = -2;
		}else if (Input.GetKey(KeyCode.D)) {
			x = 2;
		}

		if (Input.GetKey(KeyCode.S)) {
			y = -2;
		}else if (Input.GetKey(KeyCode.W)) {
			y = 2;
		}
		
		transform.position += new Vector3(x,y,0) * Time.deltaTime;
		//Debug.Log(player.transform.position);
	}
	// void OnCollisionEnter2D(Collision2D coll) { 
	// 	if (coll.gameObject.tag == "koin" ) { 
	// 		Debug.Log ( "Mulai Nabrak koin" );
	// 	} 
	// } 
	// void OnCollisionStay2D(Collision2D coll) { 
	// 	if (coll.gameObject.tag == "koin" ) { 
	// 		Debug.Log ( "Sedang Nabrak koin" ); 
	// 	} 
	// }
	// void OnCollisionExit2D(Collision2D coll) { 
	// 	if (coll.gameObject.tag == "koin") {
	// 		Debug.Log("Sudah Nabrak koin");
	// 	}
	// }
	private void OnTriggerEnter2D(Collider2D coll) {
		Destroy(coll.gameObject);
	}
}
