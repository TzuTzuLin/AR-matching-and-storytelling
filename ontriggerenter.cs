using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ontriggerenter : MonoBehaviour {

	public GameObject matchingpair;
	public GameObject disappearparticle;
	public matching_control matchingcontrol;
	public AudioSource matchingsound;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		
		Debug.Log ("ENTER!!!"+ other.gameObject);
		if (other.gameObject == matchingpair) {
			Instantiate (disappearparticle, other.transform.position,other.transform.rotation);

			if (matchingcontrol.whosturn) {
				matchingcontrol.num++;
			} else {
				matchingcontrol.numleft++;
			}

			matchingsound.Play ();
			this.gameObject.SetActive (false);
			other.gameObject.SetActive (false);
		}

	}
}
