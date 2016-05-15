using UnityEngine;
using System.Collections;

public class LevelLoader : MonoBehaviour {
	public int screenCounter;


	public void Joel(){
		Application.LoadLevel(1);
	}

	public void GreyCat(){
		PlayerPrefs.SetInt("CatColor", 0);
	}

	public void BrownCat(){
		PlayerPrefs.SetInt("CatColor", 1);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Application.loadedLevel == 1){
		screenCounter++;
		if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(2) || screenCounter > 200){
			
			Application.LoadLevel(1);

		}
		}

		if (Input.GetKeyDown(KeyCode.Escape)){
			Application.Quit();
		}
	}
}
