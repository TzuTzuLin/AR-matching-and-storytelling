using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background_appear : MonoBehaviour {
	//private float timer=0.0f;

	// Use this for initialization
	void Start () {
		//transform.localPosition += new Vector3(0.0f, -1.0f, 0.0f);
	}

	// Update is called once per frame
	void Update () {
		if (transform.localScale.x < 0.6) {
			transform.localScale += new Vector3(0.01f, 0.02f, 0.01f);
		
		}

	}
}
