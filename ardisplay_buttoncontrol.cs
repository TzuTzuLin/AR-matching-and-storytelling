using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ardisplay_buttoncontrol : MonoBehaviour {

	public GameObject Button_vol;
	public GameObject Button_big;
	public GameObject Button_small;
	public GameObject Button_home;

	public delegate void ClickedAction();
	public static event ClickedAction OnClicked_vol;
	public static event ClickedAction OnClicked_big;
	public static event ClickedAction OnClicked_small;

	// Use this for initialization
	void Start () {
		Button_vol.SetActive (false);
		Button_big.SetActive (false);
		Button_small.SetActive (false);
		Button_home.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Clicked_vol(){
		if (OnClicked_vol != null) {
			OnClicked_vol ();
		}
	}

	public void Clicked_big(){
		if (OnClicked_big != null) {
			OnClicked_big ();
		}
	}
	public void Clicked_small(){
		if (OnClicked_small != null) {
			OnClicked_small ();
		}
	}

	public void Home(){
		SceneManager.LoadScene ("SceneStart");
	}
}
