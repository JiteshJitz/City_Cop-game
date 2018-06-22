using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follo : MonoBehaviour {
	public GameObject Player;
	Vector3 off;
	void Start(){
		off = transform.position - Player.transform.position;
	}
	void LateUpdate(){
		transform.position = Player.transform.position + off;
	}
}
