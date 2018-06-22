using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire1 : MonoBehaviour {
	public GameObject obj;
	static int f = 1;
	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			if (f == 1) {
				f--;
				Debug.Log (f);
				Instantiate (obj,transform.position, transform.rotation);
			}
		}
		if (Input.GetKeyUp (KeyCode.A)){
			f=1;
		}
	}
			public void inn()
	
				{
			f = 1;
	}
}
