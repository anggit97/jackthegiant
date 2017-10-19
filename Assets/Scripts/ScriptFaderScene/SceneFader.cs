using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneFader : MonoBehaviour {

	public static SceneFader instance;

	[SerializeField]
	private GameObject fadePanel;

	[SerializeField]
	private Animator fadeAnim;

	// Use this for initialization
	void Start () {
		makeSingletion ();
	}
		
	private void makeSingletion(){
		if (instance != null) {
			Destroy (instance);	
		} else {
			instance = this;
			DontDestroyOnLoad (instance);
		}
	}

	public void loadLevel(string level){
		Debug.Log ("load level");
 		StartCoroutine (FadeInOut(level));
	}

	IEnumerator FadeInOut(string level){
		fadePanel.SetActive (true);

		fadeAnim.Play ("FadeInPanel");

		yield return StartCoroutine (MyCourutine.WaitForSecondsRealtime (1f));

		SceneManager.LoadScene (level);

		fadeAnim.Play ("FadeOutPanel");

		yield return StartCoroutine (MyCourutine.WaitForSecondsRealtime (0.7f));

		fadePanel.SetActive (false);
	}
}
