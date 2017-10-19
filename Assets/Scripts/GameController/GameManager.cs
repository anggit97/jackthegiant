using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public static GameManager instance;

	[HideInInspector]
	public bool gameStartedFromMainMenu, gameStartedAfterPlayerDied;

	[HideInInspector]
	public int score, coinScore, lifeScore;

	// Use this for initialization
	void Awake () {
		makeSingleton ();
	}

	void Start(){
		initializeVariables ();
	}

	void initializeVariables(){
		
		if (!PlayerPrefs.HasKey ("Game Initialized")) {

			GamePrefrences.setEasyDiffultyState (0);
			GamePrefrences.setEasyDiffultyScoreState (0);
			GamePrefrences.setEasyDiffultyCoinScoreState (0);

			GamePrefrences.setMediumDiffultyState (0);
			GamePrefrences.setMediumDiffultyScoreState (0);
			GamePrefrences.setMediumDiffultyCoinScoreState (0);

			GamePrefrences.setHardDiffultyState (0);
			GamePrefrences.setHardDiffultyScoreState (0);
			GamePrefrences.setHardDiffultyCoinScoreState (0);

			GamePrefrences.setMusicOnState (0);

			PlayerPrefs.SetInt ("Game Initialized", 123);

		} else {
			Debug.Log ("Test");
		}
	}

	void makeSingleton(){
		if (instance != null) {
			Destroy (gameObject);
		} else {
			instance = this;
			DontDestroyOnLoad (gameObject);
		}
	}

	void OnEnable(){
		SceneManager.sceneLoaded += LevelFinishedLoading;
	}

	void OnDisable(){
		SceneManager.sceneLoaded -= LevelFinishedLoading;
	}

	void LevelFinishedLoading(Scene scene, LoadSceneMode mode){
		if(scene.name == "Gameplay"){
			if(gameStartedAfterPlayerDied){

				GameplayController.instance.setScore (score);
				GameplayController.instance.setCoinScore (coinScore);
				GameplayController.instance.setLifeScore (lifeScore);

				PlayerScore.scoreCount = score;
				PlayerScore.coinScore = coinScore;
				PlayerScore.lifeScore = lifeScore;
			}else if(gameStartedFromMainMenu){
				PlayerScore.scoreCount = 0;
				PlayerScore.coinScore = 0;
				PlayerScore.lifeScore = 2;

				GameplayController.instance.setScore (0);
				GameplayController.instance.setCoinScore (0);
				GameplayController.instance.setLifeScore (2);
			}
		}
	}

	public void checkGameStatus(int score, int coinScore, int lifeScore){
		if (lifeScore < 0) {

			if(GamePrefrences.getEasyDifficultyState() == 1){

				int highScore = GamePrefrences.getEasyDifficultyScoreState ();
				int coin = GamePrefrences.getEasyDifficultyCoinScoreState ();

				if (highScore < score)
					GamePrefrences.setEasyDiffultyScoreState (score);

				if (coin < coinScore)
					GamePrefrences.setEasyDiffultyCoinScoreState (coinScore);
			}

			if(GamePrefrences.getMediumDifficultyState() == 1){

				int highScore = GamePrefrences.getMediumDifficultyScoreState ();
				int coin = GamePrefrences.getMediumDifficultyCoinScoreState ();

				if (highScore < score)
					GamePrefrences.setMediumDiffultyScoreState (score);

				if (coin < coinScore)
					GamePrefrences.setMediumDiffultyCoinScoreState (coinScore);
			}

			if(GamePrefrences.getHardDifficultyState() == 1){

				int highScore = GamePrefrences.getHardDifficultyScoreState ();
				int coin = GamePrefrences.getHardDifficultyCoinScoreState ();

				if (highScore < score)
					GamePrefrences.setHardDiffultyScoreState (score);

				if (coin < coinScore)
					GamePrefrences.setHardDiffultyCoinScoreState (coinScore);
			}

			gameStartedFromMainMenu = false;
			gameStartedAfterPlayerDied = false;

			GameplayController.instance.GameOverShowPanel (score, coinScore);
		
		} else {
			this.score = score;
			this.lifeScore = lifeScore;
			this.coinScore = coinScore;


			gameStartedFromMainMenu = false;
			gameStartedAfterPlayerDied = true;

			GameplayController.instance.playerDiedRestartTheGame ();
		}
	}

}
