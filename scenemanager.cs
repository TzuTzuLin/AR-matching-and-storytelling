using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scenemanager : MonoBehaviour {

	public GameObject Button_ardisplay;
	public GameObject Button_matching;
	public GameObject Button_storytelling;
	public GameObject Button_collaboration;
	public GameObject Button_competition;
	public GameObject Button_colfourpairs;
	public GameObject Button_colfivepairs;
	public GameObject Button_colsixpairs;
	public GameObject Button_comfourpairs;
	public GameObject Button_comfivepairs;
	public GameObject Button_comsixpairs;
	public GameObject Button_tellstorytogether;
	public GameObject Button_tellstorychildren;
	public GameObject Button_backtostart;
	public GameObject Button_home;
	public GameObject Button_display_walk;
	public GameObject Button_display_yay; 

	public GameObject Text_pairscollected;
	public GameObject Text_pairscollectedcount;
	public GameObject Text_leftpairscollected;
	public GameObject Text_leftpairscollectedcount;
	public GameObject Text_timer;
	public GameObject outline_leftplayer;

	public Text xpairs;
	public Text xpairs_left;

	public delegate void TellXPairs(int x);
	public static event TellXPairs SendTheNumber;
	public static event TellXPairs SendTheMode;
	public static event TellXPairs TelltoStart;
	// Use this for initialization
	public void Start () {
		Button_ardisplay.SetActive (true);
		Button_matching.SetActive (true);
		Button_storytelling.SetActive (true);
		Button_collaboration.SetActive (false);
		Button_competition.SetActive (false);
		Button_colfourpairs.SetActive (false);
		Button_colfivepairs.SetActive (false);
		Button_colsixpairs.SetActive (false);
		Button_comfourpairs.SetActive (false);
		Button_comfivepairs.SetActive (false);
		Button_comsixpairs.SetActive (false);
		Button_tellstorytogether.SetActive (false);
		Button_tellstorychildren.SetActive (false);
		Button_backtostart.SetActive (false);
		Button_home.SetActive (false);
		Button_display_walk.SetActive (false);
		Button_display_yay.SetActive (false);

		Text_pairscollected.SetActive (false);
		Text_pairscollectedcount.SetActive (false); 
		Text_leftpairscollected.SetActive (false);
		Text_leftpairscollectedcount.SetActive (false);
		Text_timer.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void GameQuit (){
		SceneManager.LoadScene ("SceneStart");
	}

	public void ARDisplayStart (){
		SceneManager.LoadScene ("ARdisplay");
	/*	Button_ardisplay.SetActive (false);
		Button_matching.SetActive (false);
		Button_storytelling.SetActive (false);
		Button_collaboration.SetActive (false);
		Button_competition.SetActive (false);
	//	Button_display_walk.SetActive (true);
	//	Button_display_yay.SetActive (true);
		Button_backtostart.SetActive (true);*/
	}
	/// <summary>
	/// Matching start.
	/// </summary>

	public void MatchingStart (){
		Button_ardisplay.SetActive (false);
		Button_matching.SetActive (false);
		Button_storytelling.SetActive (false);
		Button_collaboration.SetActive (true);
		Button_competition.SetActive (true);
		Button_backtostart.SetActive (true);
	}

	public void CollaborationPairsetting (){
		SendTheMode (0);
		Button_colfourpairs.SetActive (true);
		Button_colfivepairs.SetActive (true);
		Button_colsixpairs.SetActive (true);
		Button_backtostart.SetActive (true);
		Button_collaboration.SetActive (false);
		Button_competition.SetActive (false);
	}

	public void CollaborationFourPairMode (){
		SendTheNumber (4);
		TelltoStart (0);
		Button_colfourpairs.SetActive (false);
		Button_colfivepairs.SetActive (false);
		Button_colsixpairs.SetActive (false);
		Button_backtostart.SetActive (false);
		Button_home.SetActive (true);

		xpairs.text = "Pairs colleted:      /4";
		Text_pairscollected.SetActive (true);
		Text_pairscollectedcount.SetActive (true); 
		Text_timer.SetActive (true);
	}

	public void CollaborationFivePairMode (){
		SendTheNumber (5);
		TelltoStart (0);
		Button_colfourpairs.SetActive (false);
		Button_colfivepairs.SetActive (false);
		Button_colsixpairs.SetActive (false);
		Button_backtostart.SetActive (false);
		Button_home.SetActive (true);

		xpairs.text = "Pairs colleted:      /5";
		Text_pairscollected.SetActive (true);
		Text_pairscollectedcount.SetActive (true); 
		Text_timer.SetActive (true);
	}

	public void CollaborationSixPairMode (){
		SendTheNumber (6);
		TelltoStart (0);
		Button_colfourpairs.SetActive (false);
		Button_colfivepairs.SetActive (false);
		Button_colsixpairs.SetActive (false);
		Button_backtostart.SetActive (false);
		Button_home.SetActive (true);

		xpairs.text = "Pairs colleted:      /6";
		Text_pairscollected.SetActive (true);
		Text_pairscollectedcount.SetActive (true); 
		Text_timer.SetActive (true);
	}

	public void CompetitionPairsetting (){
		SendTheMode (1);
		Button_comfourpairs.SetActive (true);
		Button_comfivepairs.SetActive (true);
		Button_comsixpairs.SetActive (true);
		Button_backtostart.SetActive (true);
		Button_collaboration.SetActive (false);
		Button_competition.SetActive (false);
	}

	public void CompetitionFourPairMode (){
		SendTheNumber (4);
		//TelltoStart (0);
		Button_comfourpairs.SetActive (false);
		Button_comfivepairs.SetActive (false);
		Button_comsixpairs.SetActive (false);
		Button_backtostart.SetActive (false);
		Button_home.SetActive (true);
		outline_leftplayer.SetActive (true);
		xpairs.text = "Pairs colleted:      /4";
		xpairs_left.text = "Pairs colleted:      /4";
		Text_pairscollected.SetActive (true);
		Text_pairscollectedcount.SetActive (true); 
		Text_leftpairscollected.SetActive (true);
		Text_leftpairscollectedcount.SetActive (true); 
	}

	public void CompetitionFivePairMode (){
		SendTheNumber (5);
		//TelltoStart (0);
		Button_comfourpairs.SetActive (false);
		Button_comfivepairs.SetActive (false);
		Button_comsixpairs.SetActive (false);
		Button_backtostart.SetActive (false);
		Button_home.SetActive (true);
		outline_leftplayer.SetActive (true);
		xpairs.text = "Pairs colleted:      /5";
		xpairs_left.text = "Pairs colleted:      /5";
		Text_pairscollected.SetActive (true);
		Text_pairscollectedcount.SetActive (true); 
		Text_leftpairscollected.SetActive (true);
		Text_leftpairscollectedcount.SetActive (true); 
	}

	public void CompetitionSixPairMode (){
		SendTheNumber (6);
		//TelltoStart (0);
		Button_comfourpairs.SetActive (false);
		Button_comfivepairs.SetActive (false);
		Button_comsixpairs.SetActive (false);
		Button_backtostart.SetActive (false);
		Button_home.SetActive (true);
		outline_leftplayer.SetActive (true);
		xpairs.text = "Pairs colleted:      /6";
		xpairs_left.text = "Pairs colleted:      /6";
		Text_pairscollected.SetActive (true);
		Text_pairscollectedcount.SetActive (true); 
		Text_leftpairscollected.SetActive (true);
		Text_leftpairscollectedcount.SetActive (true); 
	}
	/// <summary>
	/// Storytelling
	/// </summary>
	public void StorytellingStart (){
		Button_tellstorytogether.SetActive (true);
		Button_tellstorychildren.SetActive (true);
		Button_backtostart.SetActive (true);
		Button_ardisplay.SetActive (false);
		Button_matching.SetActive (false);
		Button_storytelling.SetActive (false);
		//Button_collaboration.SetActive (false);
		//Button_competition.SetActive (false);
	}

	public void TellStoryTogether()
	{
		SceneManager.LoadScene ("Storytelling");
	}
	public void TellStoryChildren()
	{
		SceneManager.LoadScene ("Storytelling_game");
	}
}
