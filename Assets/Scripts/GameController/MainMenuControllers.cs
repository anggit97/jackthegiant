using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuControllers : MonoBehaviour {

	[SerializeField]
	private Button musicBtn;

	[SerializeField]
	private Sprite[] musicIcon;

	// Use this for initialization
	void Start () {
		checkToPlayTheMusic ();
	}

	void checkToPlayTheMusic(){
		if(GamePrefrences.getMusicState() == 1){
			MusicController.instance.playMusic (true);
			musicBtn.image.sprite = musicIcon [1];
		}else{
			MusicController.instance.playMusic (false);
			musicBtn.image.sprite = musicIcon [0];
		}
	}

	public void StartGame(){
		GameManager.instance.gameStartedFromMainMenu = true;
		SceneFader.instance.loadLevel ("Gameplay");
	}

	public void HighscoreMenu(){
		SceneManager.LoadScene ("HighScoreScene");
	}

	public void OptionsMenu(){
		SceneManager.LoadScene ("OptionsMenu");
	}

	public void QuitGame(){
		Application.Quit ();
	}

	public void MusicButton(){
		if(GamePrefrences.getMusicState() == 0){
			GamePrefrences.setMusicOnState (1);
			MusicController.instance.playMusic (true);
			musicBtn.image.sprite = musicIcon [1];
		}else if(GamePrefrences.getMusicState() == 1){
			GamePrefrences.setMusicOnState (0);
			MusicController.instance.playMusic (false);
			musicBtn.image.sprite = musicIcon [0];
		}
	}

}
