using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour {
	Rigidbody2D PlayerRigidbody;
	// Use this for initialization
	void Start () {
		PlayerRigidbody = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.eulerAngles = new Vector3 (0, 0, 0);
		PlayerRigidbody.velocity = new Vector2 (4, PlayerRigidbody.velocity.y);
	}
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.name != "Player") {
			Destroy (gameObject);
		}
	}
}
