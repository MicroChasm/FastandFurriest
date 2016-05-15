using UnityEngine;
using System.Collections;

public class UISounds : MonoBehaviour {
	public AudioClip UISound1;
	public AudioClip UISound2;
	public AudioClip UISound3;

	public AudioSource audioPlayer;

	// Use this for initialization
	void Start () {
	
	}

	public void UISoundOne(){
		audioPlayer.PlayOneShot(UISound1);
	}
	public void UISoundTwo(){
		audioPlayer.PlayOneShot(UISound2);
	}

	public void UISoundThree(){
		audioPlayer.PlayOneShot(UISound3);
	}



	// Update is called once per frame
	void Update () {
	
	}
}
