using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ar_displayanimations_bee : MonoBehaviour {

	public GameObject target;
	public GameObject targetpos;
	public float speed = 0.5f;

	private Vector3 InitialPos;

	// Use this for initialization
	void Start () {
		InitialPos = transform.localPosition;
	}
	
	// Update is called once per frame
	void Update () {
		if(!target.activeInHierarchy)
		{
			transform.localPosition = InitialPos; 
		}
		else if (this.gameObject.activeInHierarchy && target.activeInHierarchy){
			Vector3 dir = targetpos.transform.position - this.transform.position;
			float dis = Vector3.Distance (this.transform.position, targetpos.transform.position);
			//Debug.Log ("Distance: " + dir.normalized);
			if (dis > 0.1) {
				//	animalsound.Play ();
				this.transform.Translate (dir.normalized * speed * Time.deltaTime, Space.World);
				//this.transform.position = Vector3.MoveTowards (this.transform.position, target.transform.position, 0.1f);
				this.transform.LookAt (targetpos.transform.position);
			} else {
				Vector3 flyupndown = new Vector3(0.0f,1.0f,0.0f);
				this.transform.Translate (flyupndown * speed * Time.deltaTime, Space.World);
			}
		}
	}
}
