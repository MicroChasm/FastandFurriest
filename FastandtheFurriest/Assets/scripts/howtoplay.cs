using UnityEngine;
using System.Collections;

public class howtoplay : MonoBehaviour {

	public int howtoplayCounter;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		howtoplayCounter++;

		if (howtoplayCounter > 200){
			Application.LoadLevel("Level_1");
		}
	}
}
