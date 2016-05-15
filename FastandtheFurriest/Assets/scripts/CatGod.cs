using UnityEngine;
using System.Collections;

public class CatGod : MonoBehaviour {
	public int currentLevel;
	// Use this for initialization
	void Start () {
		currentLevel = Application.loadedLevel;
	}


	void OnTriggerStay2D(Collider2D other){
		if (other.name.StartsWith("player")){
			Debug.Log("winrar!");
			if (currentLevel == 2){
			Application.LoadLevel(3);
			}
			else
				{
					Application.LoadLevel(4);
				}
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
