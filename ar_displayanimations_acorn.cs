using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ar_displayanimations_acorn : MonoBehaviour {

	public GameObject game_obj;
	public GameObject Button_moreacorn;
	public GameObject copy1;
	public GameObject copy2;
	public GameObject copy3;
	public GameObject copy4;
	public GameObject copy5;
	public AudioSource outsound;
	public AudioSource nomoresound;

	private int countacorns = 0; 
	private GameObject acorn1;
	private GameObject acorn2;
	private GameObject acorn3;
	private GameObject acorn4;
	private GameObject acorn5;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (game_obj.activeInHierarchy) {
			Button_moreacorn.SetActive (true);
		} else {
			Button_moreacorn.SetActive (false);
			countacorns = 0;
			Destroy (acorn1);
			Destroy (acorn2);
			Destroy (acorn3);
			Destroy (acorn4);
			Destroy (acorn5);

		}
	}

	public void moreacorn (){
		
		if (countacorns == 0) {
			outsound.Play ();
			acorn1 = Instantiate (game_obj, copy1.transform.localPosition, Quaternion.identity);
			acorn1.transform.parent = game_obj.transform.parent.parent;
			//copy1.SetActive (true);
			countacorns++;
		} else if (countacorns == 1) {
			outsound.Play ();
			acorn2 = Instantiate (game_obj, copy2.transform.localPosition, Quaternion.identity);
			acorn2.transform.parent = game_obj.transform.parent.parent.parent;
			//copy2.SetActive (true);
			countacorns++;
		} else if (countacorns == 2) {
			outsound.Play ();
			acorn3 = Instantiate (game_obj, copy3.transform.position, Quaternion.identity);
			acorn3.transform.parent = game_obj.transform.parent.parent.parent.parent;
			countacorns++;
		} else if (countacorns == 3) {
			outsound.Play ();
			acorn4 = Instantiate (game_obj, copy4.transform.position, Quaternion.identity);
			acorn4.transform.parent = game_obj.transform.parent.parent.parent.parent.parent;
			countacorns++;
		} else if (countacorns == 4) {
			outsound.Play ();
			acorn5 = Instantiate (game_obj, copy5.transform.position, Quaternion.identity);
			acorn5.transform.parent = game_obj.transform.parent.parent.parent.parent.parent.parent.parent;
			countacorns++;
		} else {
			nomoresound.Play ();
		}
		Debug.Log (countacorns);
	
	}
}
