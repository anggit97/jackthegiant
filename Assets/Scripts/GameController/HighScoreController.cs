using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreController : MonoBehaviour {

	[SerializeField]
	private Text scoreText, coinText;

	// Use this for initialization
	void Start () {
		setScoreBasedOnDifficulty ();
	}

	void setScore(int score, int coinScore){
		scoreText.text = score.ToString ();
		coinText.text = coinScore.ToString ();
	}
	
	public void BackToMainMenu(){
		SceneManager.LoadScene ("MainMenu");
	}

	void setScoreBasedOnDifficulty(){
		if(GamePrefrences.getEasyDifficultyState() == 1){
			setScore (GamePrefrences.getEasyDifficultyScoreState(),GamePrefrences.getEasyDifficultyCoinScoreState());
		}
		if(GamePrefrences.getMediumDifficultyState() == 1){
			setScore (GamePrefrences.getMediumDifficultyScoreState(),GamePrefrences.getMediumDifficultyCoinScoreState());
		}
		if(GamePrefrences.getHardDifficultyState() == 1){
			setScore (GamePrefrences.getHardDifficultyScoreState(),GamePrefrences.getHardDifficultyCoinScoreState());
		}
	}
}
