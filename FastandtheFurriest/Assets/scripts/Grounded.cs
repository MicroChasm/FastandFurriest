using UnityEngine;
using System.Collections;

public class Grounded : MonoBehaviour {
	public bool onGround = false;

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter2D (Collider2D other){
	if (other.tag == "ground"){
	onGround = true;
	}
	}

	void OnTriggerExit2D (Collider2D other){
	if (other.tag == "ground"){
		onGround = false;
		}	
}

	// Update is called once per frame
	void Update () {
	
	}
}
