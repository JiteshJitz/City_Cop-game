using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class connect : MonoBehaviour {
	public static int but=1; 
	public Sprite[] sp;
	public AudioClip buttonsound;
	public GameObject soundbutton;//empty game object//
	public GameObject info_obj;
	void Start () {
		info_obj.SetActive (false);
	}

	public void showinfo()
	{
		info_obj.gameObject.SetActive (true);
	}
	public void hide()
	{
		info_obj.gameObject.SetActive (false);
	}
	void Update () {

	}
	//public void loadGame(){
		//GameObject.Find ("Load").GetComponent<AudioSource> ().PlayOneShot (buttonsound, 10);
		//Application.LoadLevel ("Scebe_2");
	//}
	public void stopsound(){
		if(but==1){
			but = 0;
			soundbutton.gameObject.GetComponent<Button>().GetComponent<Image>().sprite =sp[0];
			GameObject.FindGameObjectWithTag("MainCamera").GetComponent<AudioSource>().mute =!GetComponent<AudioSource>().mute;
		}
		else if (but == 0){
			but = 1;
			soundbutton.gameObject.GetComponent<Button>().GetComponent<Image>().sprite =sp[1];
			GameObject.FindGameObjectWithTag("MainCamera").GetComponent<AudioSource>().mute = GetComponent<AudioSource>().mute;
		}
	}
}
