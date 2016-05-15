using UnityEngine;
using System.Collections;

public class NoteController : MonoBehaviour {


	public AudioClip Note1;
	public AudioClip Note2;
	public AudioClip Note3;
	public AudioClip Note4;
	public AudioClip Note5;
	public AudioClip Note6;
	public AudioClip Note7;
	public AudioClip Note8;
	public AudioClip Note9;
	public AudioClip Note10;
	public AudioClip Note11;
	public AudioClip Note12;
	public AudioClip Note13;
	public AudioClip Note14;

	public SoundController soundController;
	public int cliptoPlay;
	public int switchNote;
	public float volume;
	public AudioSource notePlayer;

	// Use this for initialization
	void Awake () {
		volume = .4f;

		notePlayer = GetComponent<AudioSource>();
		soundController = GameObject.Find("SoundPlayer").GetComponent<SoundController>();
		cliptoPlay = soundController.currentNote;
		switchNote = soundController.switchPlayer;
		if (cliptoPlay == 1){
			notePlayer.PlayOneShot(Note1);
		}
		else if (cliptoPlay == 2){
			notePlayer.PlayOneShot(Note2);
		}
		else if (cliptoPlay == 3){
			notePlayer.PlayOneShot(Note3);
		}
		else if (cliptoPlay == 4){
			notePlayer.PlayOneShot(Note4);
		}
		else if (cliptoPlay == 5){
			notePlayer.PlayOneShot(Note5);
		}
		else if (cliptoPlay == 6){
			notePlayer.PlayOneShot(Note6);
		}
		else if (cliptoPlay == 7){
			notePlayer.PlayOneShot(Note7);
		}
		else if (cliptoPlay == 8){
			notePlayer.PlayOneShot(Note8);
		}
		else if (cliptoPlay == 9){
			notePlayer.PlayOneShot(Note9);
		}
		else if (cliptoPlay == 10){
			notePlayer.PlayOneShot(Note10);
		}
		else if (cliptoPlay == 11){
			notePlayer.PlayOneShot(Note11);
		}
		else if (cliptoPlay == 12){
			notePlayer.PlayOneShot(Note12);
		}
		else if (cliptoPlay == 13){
			notePlayer.PlayOneShot(Note13);
		}
		else if (cliptoPlay == 14){
			notePlayer.PlayOneShot(Note14);
		}



	}
	
	// Update is called once per frame
	void Update () {

		notePlayer.volume = volume;
		if (soundController.switchPlayer != switchNote){
		volume -= .025f;
		}

		if (volume <= 0)
		{
			Destroy(gameObject);
		}

	}
}
