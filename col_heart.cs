﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col_heart : MonoBehaviour {
	public INSCORE In;

	// Use this for initialization
	void Start () {
		In = GameObject.Find ("NIL").GetComponent<INSCORE> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.name == "idle") {
			In.SendMessage ("LiUp");
			Destroy (gameObject);
		}
	}
}

