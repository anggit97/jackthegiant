using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class OptionsController : MonoBehaviour {

	[SerializeField]
	private GameObject easyCheckSign, mediumCheckSign, hardCheckSign;

	// Use this for initialization
	void Start () {
		setTheDifficulty ();
	}

	void setInitalDifficulty(string difficulty){
		switch(difficulty){
		case "easy":
			mediumCheckSign.SetActive (false);
			hardCheckSign.SetActive (false);
			break;

		case "medium":
			easyCheckSign.SetActive (false);
			hardCheckSign.SetActive (false);
			break;

		case "hard":
			easyCheckSign.SetActive (false);
			mediumCheckSign.SetActive (false);
			break;
		}

	}

	void setTheDifficulty(){
		if(GamePrefrences.getEasyDifficultyState() == 1){
			setInitalDifficulty ("easy");
		}

		if(GamePrefrences.getMediumDifficultyState() == 1){
			setInitalDifficulty ("medium");
		}

		if(GamePrefrences.getMediumDifficultyState() == 1){
			setInitalDifficulty ("hard");
		}
	}

	public void easyDifficulty(){
		GamePrefrences.setEasyDiffultyState (1);
		GamePrefrences.setMediumDiffultyState (0);
		GamePrefrences.setHardDiffultyState (0);

		easyCheckSign.SetActive (true);
		mediumCheckSign.SetActive (false);
		hardCheckSign.SetActive (false);
	}

	public void mediumDifficulty(){
		GamePrefrences.setEasyDiffultyState (0);
		GamePrefrences.setMediumDiffultyState (1);
		GamePrefrences.setHardDiffultyState (0);

		easyCheckSign.SetActive (false);
		mediumCheckSign.SetActive (true);
		hardCheckSign.SetActive (false);
	}

	public void hardDifficulty(){
		GamePrefrences.setEasyDiffultyState (0);
		GamePrefrences.setMediumDiffultyState (0);
		GamePrefrences.setHardDiffultyState (1);

		easyCheckSign.SetActive (false);
		mediumCheckSign.SetActive (false);
		hardCheckSign.SetActive (true);
	}

	public void BackToMainMenu(){
		SceneManager.LoadScene ("MainMenu");
	}
}
