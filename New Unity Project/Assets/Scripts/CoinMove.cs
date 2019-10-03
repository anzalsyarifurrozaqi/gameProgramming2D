using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMove : MonoBehaviour {

	// Use this for initialization
	public float speed;
	Vector3 kebawah;
	Vector2 screenBounds;
	void Start () {
		kebawah = new Vector3(0,-1,0);
		screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Camera.main.transform.position.y, Camera.main.transform.position.z));
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += (kebawah * speed * Time.deltaTime);
		if (transform.position.y < screenBounds.y) {
			Destroy(this.gameObject);
		}
	}
}
