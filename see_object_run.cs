/*==============================================================================
Copyright (c) 2010-2014 Qualcomm Connected Experiences, Inc.
All Rights Reserved.
Confidential and Proprietary - Protected under copyright and other laws.
==============================================================================*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

/// <summary>
/// A custom handler that implements the ITrackableEventHandler interface.
/// </summary>
public class see_object_run : MonoBehaviour{
	
	public GameObject target;
	public float speed = 0.5f;
	//public AudioSource animalsound;

	private Vector3 InitialPos;
	private Vector3 tempvec;

	#region UNTIY_MONOBEHAVIOUR_METHODS

	void Start()
	{
		InitialPos = transform.localPosition;
		//Debug.Log ("START POS: " + target.localPosition);
		//	animator = GetComponentInChildren<Animator> ();

		//tempvec = target.position;
	}

	#endregion // UNTIY_MONOBEHAVIOUR_METHODS

	void Update (){
		
		//if (target.position!=tempvec){
		if(!target.activeInHierarchy)
		{
			transform.localPosition = InitialPos; 
		}
		else if (this.gameObject.activeInHierarchy && target.activeInHierarchy){
			Vector3 dir = target.transform.position - this.transform.position;
			float dis = Vector3.Distance (this.transform.position, target.transform.position);
			//Debug.Log ("Distance: " + dir.normalized);
			if (dis > 0.1) {
			//	animalsound.Play ();
				this.transform.Translate (dir.normalized * speed * Time.deltaTime, Space.World);
				//this.transform.position = Vector3.MoveTowards (this.transform.position, target.transform.position, 0.1f);
				this.transform.LookAt (target.transform.position);

			} 
		}
			
	}

	void OnEnable(){
		transform.localPosition = InitialPos; 
		//Debug.Log ("on enable POS: " + InitialPos);

	}

}

