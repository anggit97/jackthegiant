using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameplayController : MonoBehaviour {

	public static GameplayController instance;

	[SerializeField]
	private Text scoreText, coinText, lifeText, gameOverScoreText, gameOverCoinText;

	[SerializeField]
	private GameObject pausePanel, gameOverPanel, readyPanel;

	// Use this for initialization
	void Awake () {
		makeInstance ();
	}

	void Start(){
		Time.timeScale = 0f;
	}

	private void makeInstance(){
		if (instance == null) {
			instance = this;
		}
	}

	public void GameOverShowPanel(int finalScore, int finalCoinScore){
		gameOverPanel.SetActive (true);
		gameOverCoinText.text = finalCoinScore.ToString ();
		gameOverScoreText.text = finalScore.ToString ();

		StartCoroutine (gameOverLoadMenu());
	}

	IEnumerator gameOverLoadMenu(){
		yield return new WaitForSeconds (3f);
		SceneManager.LoadScene ("MainMenu");
	}

	public void playerDiedRestartTheGame(){
		StartCoroutine (playerDiedRestart());
	}

	IEnumerator playerDiedRestart(){
		yield return new WaitForSeconds (1f);
		SceneManager.LoadScene ("Gameplay");
	}

	public void setCoinScore(int coinScore){
		coinText.text = "x" + coinScore;
	}

	public void setScore(int score){
		scoreText.text = "x" + score;
	}

	public void setLifeScore(int lifeScore){
		lifeText.text = "x" + lifeScore;
	}

	public void pauseTheGame(){
		Time.timeScale = 0f;
		pausePanel.SetActive (true);
	}

	public void resumeTheGame(){
		Time.timeScale = 1f;
		pausePanel.SetActive (false);
	}

	public void quitTheGame(){
		Time.timeScale = 1f;
		SceneManager.LoadScene ("MainMenu");
	}

	public void startGame(){
		Time.timeScale = 1f;
		readyPanel.SetActive (false);
	}
}
