using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePrefrences : MonoBehaviour {

	public static string EasyDifficulty = "EasyDifficulty";
	public static string MediumDifficulty = "MediumDifficulty";
	public static string HardDiffuclty = "HardDiffuclty";

	public static string EasyDifficultyScore = "EasyDifficultyScore";
	public static string MediumDifficultyScore = "MediumDifficultyScore";
	public static string HardDifficultyScore = "HardDifficultyScore";

	public static string EasyDifficultyCoinScore = "EasyDifficultyCoinScore";
	public static string MediumDifficultyCoinScore = "MediumDifficultyCoinScore";
	public static string HardDifficultyCoinScore = "HardDifficultyCoinScore";

	public static string isMusicOn = "isMusicOn";

	public static int getMusicState(){
		return PlayerPrefs.GetInt (GamePrefrences.isMusicOn);
	}

	public static void setMusicOnState(int state){
		PlayerPrefs.SetInt (GamePrefrences.isMusicOn,state);
	}

	public static int getEasyDifficultyState(){
		return PlayerPrefs.GetInt (GamePrefrences.EasyDifficulty);
	}

	public static void setEasyDiffultyState(int state){
		PlayerPrefs.SetInt (GamePrefrences.EasyDifficulty,state);
	}

	public static int getMediumDifficultyState(){
		return PlayerPrefs.GetInt (GamePrefrences.MediumDifficulty);
	}

	public static void setMediumDiffultyState(int state){
		PlayerPrefs.SetInt (GamePrefrences.MediumDifficulty,state);
	}

	public static int getHardDifficultyState(){
		return PlayerPrefs.GetInt (GamePrefrences.HardDiffuclty);
	}

	public static void setHardDiffultyState(int state){
		PlayerPrefs.SetInt (GamePrefrences.HardDiffuclty,state);
	}




	public static int getEasyDifficultyScoreState(){
		return PlayerPrefs.GetInt (GamePrefrences.EasyDifficultyScore);
	}

	public static void setEasyDiffultyScoreState(int state){
		PlayerPrefs.SetInt (GamePrefrences.EasyDifficultyScore,state);
	}

	public static int getMediumDifficultyScoreState(){
		return PlayerPrefs.GetInt (GamePrefrences.MediumDifficultyScore);
	}

	public static void setMediumDiffultyScoreState(int state){
		PlayerPrefs.SetInt (GamePrefrences.MediumDifficultyScore,state);
	}

	public static int getHardDifficultyScoreState(){
		return PlayerPrefs.GetInt (GamePrefrences.HardDifficultyScore);
	}

	public static void setHardDiffultyScoreState(int state){
		PlayerPrefs.SetInt (GamePrefrences.HardDifficultyScore,state);
	}




	public static int getEasyDifficultyCoinScoreState(){
		return PlayerPrefs.GetInt (GamePrefrences.EasyDifficultyCoinScore);
	}

	public static void setEasyDiffultyCoinScoreState(int state){
		PlayerPrefs.SetInt (GamePrefrences.EasyDifficultyCoinScore,state);
	}

	public static int getMediumDifficultyCoinScoreState(){
		return PlayerPrefs.GetInt (GamePrefrences.MediumDifficultyCoinScore);
	}

	public static void setMediumDiffultyCoinScoreState(int state){
		PlayerPrefs.SetInt (GamePrefrences.MediumDifficultyCoinScore,state);
	}

	public static int getHardDifficultyCoinScoreState(){
		return PlayerPrefs.GetInt (GamePrefrences.HardDifficultyCoinScore);
	}

	public static void setHardDiffultyCoinScoreState(int state){
		PlayerPrefs.SetInt (GamePrefrences.HardDifficultyCoinScore,state);
	}
}
