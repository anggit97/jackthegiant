using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableScript : MonoBehaviour {

	void onEnable(){
		Invoke ("DestroyCollactable",6f);
	}

	void DestroyCollactable(){
		gameObject.SetActive (false);
	}

}
