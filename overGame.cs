using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class overGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.name == "idle") {
			Application.LoadLevel ("Scene_2_1");
		}
	}
}
