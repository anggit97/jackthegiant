﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour {

	public static MusicController instance;

	private AudioSource audioSource;

	// Use this for initialization
	void Start () {
		makeSingleton ();
		audioSource = GetComponent<AudioSource> ();
	}
	
	private void makeSingleton(){
		if (instance != null) {
			Destroy (gameObject);
		} else {
			instance = this;
			DontDestroyOnLoad (gameObject);
		}
	}

	public void playMusic(bool play){
		if (play) {
			if (!audioSource.isPlaying) {
				audioSource.Play ();
			}
		} else {
			if(audioSource.isPlaying){
				audioSource.Stop ();
			}
		}
	}
}
