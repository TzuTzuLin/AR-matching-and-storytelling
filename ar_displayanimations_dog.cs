using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia; 

public class ar_displayanimations_dog : MonoBehaviour {

	//private TrackableBehaviour mTrackableBehaviour;
	public GameObject game_obj;
	public GameObject Button_vol;
	public GameObject Button_big;
	public GameObject Button_small;

	public Animator animationClips;
	public AudioSource pronounciation;
	public AudioSource sound;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (game_obj.activeInHierarchy) {
			Button_vol.SetActive (true);
			Button_big.SetActive (true);
			Button_small.SetActive (true);
		} else {
			Button_vol.SetActive (false);
			Button_big.SetActive (false);
			Button_small.SetActive (false);
		}
	}

	void OnEnable()
	{
		DefaultTrackableEventHandler_ARdisplay.OnDetected += ARdisplay;
		ardisplay_buttoncontrol.OnClicked_vol += VolcabularyDisplay;
		ardisplay_buttoncontrol.OnClicked_big += turnbig;
		ardisplay_buttoncontrol.OnClicked_small += turnsmall;
	}

	void OnDisable()
	{
		DefaultTrackableEventHandler_ARdisplay.OnDetected -= ARdisplay;
		ardisplay_buttoncontrol.OnClicked_vol -= VolcabularyDisplay;
		ardisplay_buttoncontrol.OnClicked_big -= turnbig;
		ardisplay_buttoncontrol.OnClicked_small -= turnsmall;
	}

	void ARdisplay(){
		animationClips.Play ("Dog_body|Dog_bodyAction");
		//Debug.Log ("display!!!");
		sound.Play ();
	}

	private void VolcabularyDisplay(){
		animationClips.Play ("Text|TextAction");
		pronounciation.Play ();
	}
	private void turnbig(){
		animationClips.Play ("Dog_body|Dog_bodyAction");
		game_obj.transform.localScale += new Vector3(2.0f, 2.0f, 2.0f);
	}

	private void turnsmall(){
		animationClips.Play ("Dog_body|Dog_bodyAction");
		if (game_obj.transform.localScale.x > 2.5f) {
			game_obj.transform.localScale -= new Vector3(2.0f, 2.0f, 2.0f);
		}
		//prevent from getting minus
		else if(game_obj.transform.localScale.x <= 2.5f && game_obj.transform.localScale.x >1.0f) {
			game_obj.transform.localScale -= new Vector3(1.0f, 1.0f, 1.0f);
		}
	}
}
