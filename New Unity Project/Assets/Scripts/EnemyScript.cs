using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

	// Use this for initialization
	Vector3 kebawah;
	Vector2 screenBounds;
	public float movespeed;
	public GameObject player;
	void Start () {
		kebawah = new Vector3(0,-1,0);
		screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Camera.main.transform.position.y, Camera.main.transform.position.z));
	}
	
	// Update is called once per frame
	void Update () {

		// if(player.transform.position.x > transform.position.x) {
		// 	transform.position = new Vector3 (transform.position.x + movespeed * Time.deltaTime, transform.position.y);
		// }

		// if(player.transform.position.x < transform.position.x) {
		// 	transform.position = new Vector3 (transform.position.x - movespeed * Time.deltaTime, transform.position.y);
		// }

		// if(player.transform.position.y > transform.position.y) {
		// 	transform.position = new Vector3 (transform.position.x, transform.position.y + movespeed * Time.deltaTime);
		// }

		// if(player.transform.position.y < transform.position.y) {
		// 	transform.position = new Vector3 (transform.position.x, transform.position.y - movespeed * Time.deltaTime);
		// }
		transform.position += (kebawah * movespeed * Time.deltaTime);
		if (transform.position.y < screenBounds.y) {
			Destroy(this.gameObject);
		}
	}
	void OnCollisionEnter2D( Collision2D coll) { 
		if (coll.gameObject.tag == "Player" ) { 
			Debug.Log("Game over");
			Time.timeScale=0; 
		} 
	} 
	void OnCollisionStay2D( Collision2D coll) { 
		if (coll.gameObject.tag == "Player" ) { 
			Debug .Log ( "Sedang Nabrak" ); 
		} 
	}
	void OnCollisionExit2D( Collision2D coll) { 
		if (coll.gameObject.tag == "Player") {
			Debug.Log("Sudah Nabrak");
		}
	}
}
