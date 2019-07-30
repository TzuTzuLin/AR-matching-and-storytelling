using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class matching_control : MonoBehaviour {

	public Text Score;
	public Text Score_left;
	public Text Timer;
	public Text Finishtime;
	public int num;
	public int numleft;
	// false = left player, true = right player
	public bool whosturn = true;

	public AudioSource youwin;
	public AudioSource wrong;
	//markers
	public GameObject pair1;
	public GameObject pair11;
	public GameObject pair2;
	public GameObject pair22;
	public GameObject pair3;
	public GameObject pair33;
	public GameObject pair4;
	public GameObject pair44;
	public GameObject pair5;
	public GameObject pair55;
	public GameObject pair6;
	public GameObject pair66;

	public GameObject outline_leftplayer;
	public GameObject outline_rightplayer;
	public GameObject Text_pairscollected;
	public GameObject Text_pairscollectedcount;
	public GameObject Text_leftpairscollected;
	public GameObject Text_leftpairscollectedcount;
	public GameObject Text_timer;
	public GameObject Text_youwin;
	public GameObject Text_redwin;
	public GameObject Text_bluewin;
	public GameObject Text_bothwin;
	public GameObject Redcross;
	public GameObject Button_home;


	private int mode;
	private int targetnum = 6;
	private float timer_f= 0.0f;
	private int timer_i=0;
	private int pair1active;
	private int pair11active;
	private int pair2active;
	private int pair22active;
	private int pair3active;
	private int pair33active;
	private int pair4active;
	private int pair44active;
	private int pair5active;
	private int pair55active;
	private int pair6active;
	private int pair66active;
	private int totalactive;
	private bool hasplayedaudio = false;
	private bool hasplayedhurray = false;
	private bool startmatching = false;
	private bool isminute = false;

	// Use this for initialization
	void Start () {
		num = 0;
		numleft = 0;

		Redcross.SetActive (false);
	}

	void OnEnable()
	{
		scenemanager.SendTheNumber += setnum;
		scenemanager.SendTheMode += setmode;
		scenemanager.TelltoStart += callstart;
	}
	void OnDisable()
	{
		scenemanager.SendTheNumber -= setnum;
		scenemanager.SendTheMode -= setmode;
		scenemanager.TelltoStart -= callstart;
	}

	void setnum (int x)
	{
		targetnum = x;
	}

	void setmode (int y)
	{
		mode = y;
	}
	void callstart (int z)
	{
		if (z == 0) {
			startmatching = true; 
		}
	}
	// Update is called once per frame
	void Update () {

		if (startmatching) {
			timer_f += Time.deltaTime;
			timer_i = (int)timer_f;
			if (timer_i / 60 >= 1) {
				Timer.text = "Time: "+timer_i/60+ " min "+timer_i%60 + " sec";
			} else {
				Timer.text = "Time: "+timer_i+ " sec";
			}
		}

		if (pair1.activeInHierarchy) {
			pair1active = 1;
		} else {
			pair1active = 0;
		}
		if (pair11.activeInHierarchy) {
			pair11active = 1;
		} else {
			pair11active = 0;
		}
		if (pair2.activeInHierarchy) {
			pair2active = 1;
		} else {
			pair2active = 0;
		}
		if (pair22.activeInHierarchy) {
			pair22active = 1;
		} else {
			pair22active = 0;
		}
		if (pair3.activeInHierarchy) {
			pair3active = 1;
		} else {
			pair3active = 0;
		}
		if (pair33.activeInHierarchy) {
			pair33active = 1;
		} else {
			pair33active = 0;
		}
		if (pair4.activeInHierarchy) {
			pair4active = 1;
		} else {
			pair4active = 0;
		}
		if (pair44.activeInHierarchy) {
			pair44active = 1;
		} else {
			pair44active = 0;
		}
		if (pair5.activeInHierarchy) {
			pair5active = 1;
		} else {
			pair5active = 0;
		}
		if (pair55.activeInHierarchy) {
			pair55active = 1;
		} else {
			pair55active = 0;
		}
		if (pair6.activeInHierarchy) {
			pair6active = 1;
		} else {
			pair6active = 0;
		}
		if (pair66.activeInHierarchy) {
			pair66active = 1;
		} else {
			pair66active = 0;
		}

		// collaboration mode
		if (mode == 0) {
			Score.text = " "+num;

			// win anouncement
			if (num == targetnum) {
				startmatching = false;
				Text_timer.SetActive (false);
				if (timer_i / 60 >= 1) {
					Finishtime.text = "YAY! You made it!!! \n Time: "+timer_i/60+ " min "+timer_i%60 + " sec";
				} else {
					Finishtime.text = "YAY! You made it!!! \n Time: "+timer_i+ " sec";
				}

				Text_youwin.SetActive (true);
				Button_home.SetActive (true);
				Text_pairscollected.SetActive (false);
				Text_pairscollectedcount.SetActive (false);
				if (!hasplayedhurray) {
					hasplayedhurray = true;
					youwin.Play ();
				}
			}
			// less than two markers appear, no Redcross
			if ((pair1active + pair11active
				+ pair2active + pair22active
				+ pair3active + pair33active
				+ pair4active + pair44active
				+ pair5active + pair55active
				+ pair6active + pair66active) < 2) {
				Redcross.SetActive (false);
				hasplayedaudio = false;
			}
			// if there is any matching pairs
			else if (!((pair1.activeInHierarchy && pair11.activeInHierarchy)
				|| (pair2.activeInHierarchy && pair22.activeInHierarchy)
				|| (pair3.activeInHierarchy && pair33.activeInHierarchy)
				|| (pair4.activeInHierarchy && pair44.activeInHierarchy)
				|| (pair5.activeInHierarchy && pair55.activeInHierarchy)
				|| (pair6.activeInHierarchy && pair66.activeInHierarchy))) {

				Redcross.SetActive (true);
				if (!hasplayedaudio) {
					hasplayedaudio = true;
					wrong.Play ();
				}

			} 
		}
		// competition mode
		if (mode == 1) {
			Score.text = " "+num;
			Score_left.text = " "+numleft;

			// win anouncement
			if ((num+numleft) == targetnum) {
				// display who wins
				if (num > numleft) {
					Text_bluewin.SetActive (true);
				} else if (num < numleft) {
					Text_redwin.SetActive (true);
				} else {
					Text_bothwin.SetActive (true);
				}

				Button_home.SetActive (true);
				Text_pairscollected.SetActive (false);
				Text_pairscollectedcount.SetActive (false);
				Text_leftpairscollected.SetActive (false);
				Text_leftpairscollectedcount.SetActive (false);
				outline_leftplayer.SetActive (false);
				outline_rightplayer.SetActive (false);
				if (!hasplayedhurray) {
					hasplayedhurray = true;
					youwin.Play ();
				}
			}

			// less than two markers appear, no Redcross
			if ((pair1active + pair11active
				+ pair2active + pair22active
				+ pair3active + pair33active
				+ pair4active + pair44active
				+ pair5active + pair55active
				+ pair6active + pair66active) < 2) {
				Redcross.SetActive (false);
				hasplayedaudio = false;

			}
			// if there is any matching pairs
			else if (!((pair1.activeInHierarchy && pair11.activeInHierarchy)
				|| (pair2.activeInHierarchy && pair22.activeInHierarchy)
				|| (pair3.activeInHierarchy && pair33.activeInHierarchy)
				|| (pair4.activeInHierarchy && pair44.activeInHierarchy)
				|| (pair5.activeInHierarchy && pair55.activeInHierarchy)
				|| (pair6.activeInHierarchy && pair66.activeInHierarchy))) {

				Redcross.SetActive (true);
				if (!hasplayedaudio) {
					hasplayedaudio = true;
					wrong.Play ();
					//change turns
					if (!whosturn) {
						whosturn = true;
						outline_leftplayer.SetActive (false);
						outline_rightplayer.SetActive (true);
					} else {
						whosturn = false;
						outline_leftplayer.SetActive (true);
						outline_rightplayer.SetActive (false);
					}
				}


			} 
		}
	}

}
