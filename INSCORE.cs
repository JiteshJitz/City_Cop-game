using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class INSCORE : MonoBehaviour {
	static int score;
	public Text G;
	private int li;
	public GameObject g1;
	public GameObject g2;
	public GameObject g3;
	public GameObject g4;
	// Use this for initialization
	void Start () {
		li = 3;
		G.text = score.ToString();
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Inscore(){
		score = score + 1;
		G.text = score.ToString ();
	}
	public void Descore(){
		Debug.Log ("OVER");
		li = li - 1;
		if (li == 3) {
			g4.gameObject.SetActive (false);
		}
		else if(li==2)
		{
			g3.gameObject.SetActive (false);
		}
		else if(li==1)
		{
			g2.gameObject.SetActive(false);
		}
		else if(li==0)
		{
		Application.LoadLevel ("Scene_2_1");
		}
	}

	public void LiUp(){
		li = li + 1;
		if (li == 4) {
			g4.gameObject.SetActive (true);
		} else if (li == 3) {
			g3.gameObject.SetActive (true);
		} else if (li == 2) {
			g2.gameObject.SetActive (true);
		} else if (li == 1) {
			g1.gameObject.SetActive (true);
		}
	}
	public void Click(){
		Application.LoadLevel ("sc_1");
	}
}
