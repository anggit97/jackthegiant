using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScaler : MonoBehaviour {

	// Use this for initialization
	void Start () {

		SpriteRenderer sr = GetComponent<SpriteRenderer> ();
		Vector3 tempScale = transform.localScale;

		float width = sr.sprite.bounds.size.x;
		float wordlHeight = Camera.main.orthographicSize * 1f;
		float worldWidth = wordlHeight / Screen.width * Screen.height;

		tempScale.x = worldWidth / width;

		transform.localScale = tempScale;

	}

}
