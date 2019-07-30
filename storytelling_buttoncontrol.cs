using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class storytelling_buttoncontrol : MonoBehaviour {

	public GameObject Button_home;
	public AudioSource BGM;

	private bool BGMisplayed = false;

	// Use this for initialization
	void Start () {
		Button_home.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PlayBGM(){
		if (!BGMisplayed) {
			BGM.Play ();
			BGMisplayed = true;
		} else {
			BGM.Pause ();
			BGMisplayed = false;
		}
	}

	public void Home(){
		SceneManager.LoadScene ("SceneStart");
	}
}
