using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class storytelling_game : MonoBehaviour {

	//public GameObject raineffect;
	public GameObject fireeffect;
	public GameObject fireeffect1;
	public GameObject fireeffect2;
	public Text background;
	public Text character;
	public Text item;
	public GameObject moreitembutton1;
	public GameObject moreitembutton2;
	public Text moreitem1;
	public Text moreitem2;
	public Text Operations;
	public Text countshow;
	public AudioSource correctsound;
	public AudioSource wrongsound;
	public AudioSource BGM;

	private int countstory = 0;
	private int x;
	private int y;
	private int z;
	private int a = 11;
	private int b = 12;
	private bool BGMisplayed = false;
	private bool isfiring = false;
	private bool morebutton1turnedon = false;
	private bool morebutton2turnedon = false;

	// Use this for initialization
	void Start () {
		//raineffect.SetActive (false);
		fireeffect.SetActive (false);
		fireeffect1.SetActive (false);
		fireeffect2.SetActive (false);
		moreitembutton1.SetActive (false);
		moreitembutton2.SetActive (false);
		// 2 backgrounds
		x = Random.Range(0, 3);
		//English version
		/*if (x == 0) {
			background.text = "Forest";
		} else if (x == 1){
			background.text = "Desert";
		} else {
			background.text = "Stone hill";
		}
		// six characters
		int y = Random.Range (0, 6);
		if (y == 0) {
			character.text = "Monkey";
		} else if (y == 1) {
			character.text = "Dog";
		} else if (y == 2) {
			character.text = "Bird";
		} else if (y == 3) {
			character.text = "Rabbit";
		} else if (y == 4) {
			character.text = "Squirrel";
		} else {
			character.text = "Bee";
		}
		// six items
		int z = Random.Range (6, 12);
		if (z == 6) {
			item.text = "Banana";
		} else if (z == 7) {
			item.text = "Bone";
		} else if (z == 8) {
			item.text = "Worm";
		} else if (z == 9) {
			item.text = "Carrot";
		} else if (z == 10) {
			item.text = "Acron";
		} else {
			item.text = "Flower";
		}*/

		//Chinese version
		if (x == 0) {
			background.text = "森林";
		} else if (x == 1){
			background.text = "沙漠";
		} else {
			background.text = "石頭山丘";
		}
		// six characters
		y = Random.Range (0, 6);
		if (y == 0) {
			character.text = "猴子";
		} else if (y == 1) {
			character.text = "小狗";
		} else if (y == 2) {
			character.text = "小鳥";
		} else if (y == 3) {
			character.text = "兔子";
		} else if (y == 4) {
			character.text = "松鼠";
		} else {
			character.text = "蜜蜂";
		}
		// six items
		z = Random.Range (6, 12);
		if (z == 6) {
			item.text = "香蕉";
		} else if (z == 7) {
			item.text = "骨頭";
		} else if (z == 8) {
			item.text = "小蟲蟲";
		} else if (z == 9) {
			item.text = "紅蘿蔔";
		} else if (z == 10) {
			item.text = "橡果";
		} else {
			item.text = "小花";
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void changetopic ()
	{
		// reset the morebuttons
		//raineffect.SetActive (false);
		moreitembutton1.SetActive (false);
		moreitembutton2.SetActive (false);
		morebutton1turnedon = false;
		morebutton2turnedon = false;
		fireeffect.SetActive (false);
		fireeffect1.SetActive (false);
		fireeffect2.SetActive (false);
		isfiring = false;
		a = 11;
		b = 12;
		Operations.text = "+              +";

		//Pass button
		correctsound.Play ();
		countstory++;
		countshow.text = "Good stories: " + countstory;
		// 2 backgrounds
		x = Random.Range(0,3);

		//English version
		/*
		if (x == 0) {
			background.text = "Forest";
		} else if (x == 1){
			background.text = "Desert";
		} else {
			background.text = "Stone hill";
		}
		// six characters
		int y = Random.Range (0, 6);
		if (y == 0) {
			character.text = "Monkey";
		} else if (y == 1) {
			character.text = "Dog";
		} else if (y == 2) {
			character.text = "Bird";
		} else if (y == 3) {
			character.text = "Rabbit";
		} else if (y == 4) {
			character.text = "Squirrel";
		} else {
			character.text = "Bee";
		}
		// six items
		int z = Random.Range (6, 12);
		if (z == 6) {
			item.text = "Banana";
		} else if (z == 7) {
			item.text = "Bone";
		} else if (z == 8) {
			item.text = "Worm";
		} else if (z == 9) {
			item.text = "Carrot";
		} else if (z == 10) {
			item.text = "Acron";
		} else {
			item.text = "Flower";
		}*/

		//Chinese version
		if (x == 0) {
			background.text = "森林";
		} else if (x == 1){
			background.text = "沙漠";
		} else {
			background.text = "石頭山丘";
		}
		// six characters
		y = Random.Range (0, 6);
		if (y == 0) {
			character.text = "猴子";
		} else if (y == 1) {
			character.text = "小狗";
		} else if (y == 2) {
			character.text = "小鳥";
		} else if (y == 3) {
			character.text = "兔子";
		} else if (y == 4) {
			character.text = "松鼠";
		} else {
			character.text = "蜜蜂";
		}
		// six items
		z = Random.Range (6, 12);
		if (z == 6) {
			item.text = "香蕉";
		} else if (z == 7) {
			item.text = "骨頭";
		} else if (z == 8) {
			item.text = "小蟲蟲";
		} else if (z == 9) {
			item.text = "紅蘿蔔";
		} else if (z == 10) {
			item.text = "橡果";
		} else {
			item.text = "小花";
		}
	}

	public void popmore(){
		if (!morebutton1turnedon) {
			Operations.text = "+              +\n+                ";
			moreitembutton1.SetActive (true);
			morebutton1turnedon = true;
			while (a == 11 || a == y || a == z) {
				a = Random.Range (0, 12);
			}
			if (a == 0) {
				moreitem1.text = "猴子";
			} else if (a == 1) {
				moreitem1.text = "小狗";
			} else if (a == 2) {
				moreitem1.text = "小鳥";
			} else if (a == 3) {
				moreitem1.text = "兔子";
			} else if (a == 4) {
				moreitem1.text = "松鼠";
			} else if (a == 5) {
				moreitem1.text = "蜜蜂";
			} else if (a == 6) {
				moreitem1.text = "香蕉";
			} else if (a == 7) {
				moreitem1.text = "骨頭";
			} else if (a == 8) {
				moreitem1.text = "小蟲蟲";
			} else if (a == 9) {
				moreitem1.text = "紅蘿蔔";
			} else if (a == 10) {
				moreitem1.text = "橡果";
			} else {
				moreitem1.text = "小花";
			}
				
		} else if (!morebutton2turnedon) {
			Operations.text = "+              +\n+              +";
			moreitembutton2.SetActive (true);
			morebutton2turnedon = true;
			while (b == 12 || b == a || b == y || b == z) {
				b = Random.Range (0, 12);
			}
			if (b == 0) {
				moreitem2.text = "猴子";
			} else if (b == 1) {
				moreitem2.text = "小狗";
			} else if (b == 2) {
				moreitem2.text = "小鳥";
			} else if (b == 3) {
				moreitem2.text = "兔子";
			} else if (b == 4) {
				moreitem2.text = "松鼠";
			} else if (b == 5) {
				moreitem2.text = "蜜蜂";
			} else if (b == 6) {
				moreitem2.text = "香蕉";
			} else if (b == 7) {
				moreitem2.text = "骨頭";
			} else if (b == 8) {
				moreitem2.text = "小蟲蟲";
			} else if (b == 9) {
				moreitem2.text = "紅蘿蔔";
			} else if (b == 10) {
				moreitem2.text = "橡果";
			} else {
				moreitem2.text = "小花";
			}
		} else {
			wrongsound.Play ();
			return;
		}
			
	}

	public void fire()
	{
		if (!isfiring) {
			fireeffect.SetActive (true);
			fireeffect1.SetActive (true);
			fireeffect2.SetActive (true);
			isfiring = true;
		} else {
			fireeffect.SetActive (false);
			fireeffect1.SetActive (false);
			fireeffect2.SetActive (false);
			isfiring = false;
		}

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
