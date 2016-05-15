using UnityEngine;
using System.Collections;

public class MenuController : MonoBehaviour {

	public int quitCounter;

	void End(){
		Application.Quit();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		quitCounter++;
	
		if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(2) || quitCounter > 200){
			Application.Quit();
		}

	}
}
