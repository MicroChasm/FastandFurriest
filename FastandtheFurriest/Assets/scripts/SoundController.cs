using UnityEngine;
using System.Collections;

public class SoundController : MonoBehaviour {

	//sound clips

	public GameObject notePlayer;
	public int currentNote;
	public int switchPlayer = 1;
	public AudioClip footstep1;
	public AudioClip footstep2;
	public AudioClip jump;
	public AudioClip land;
	public AudioClip silence;
	public AudioClip tunaPickup;
	public GameObject notePlayer2;




	//variables
	public float varLowRange = 0.85f;
	public float varHighRange = 1.5f;
	public float currentVolume;
	public float currentPitch;
	public bool isPlaying;
	public int currentFootstep;
	//public float pitchBend = 1;
	//public float pitchBendTarget = 1;
	public int tunaHolder;

	//object references
	public AudioSource audioPlayer;
	public PlayerController playerController;





	/*
	void OnTriggerEnter2D(Collider2D other){
		if (other.name.StartsWith("ground")){
			pitchBendTarget = Random.Range(-3,3);
		}
	}
	*/


	void OnTriggerEnter2D(Collider2D other){

		if (other.name.StartsWith("noteA") || other.name.StartsWith("wallA")){
			currentNote = 1;
			switchPlayer *= -1;
			if (Application.loadedLevelName == "Level_2"){
				Instantiate(notePlayer2, new Vector3(0,0,0), Quaternion.identity);

			}
				else {
			Instantiate(notePlayer, new Vector3(0,0,0), Quaternion.identity);
				}
		}

		if (other.name.StartsWith("noteB") || other.name.StartsWith("wallB")){
			currentNote = 2;
			switchPlayer *= -1;
			if (Application.loadedLevelName == "Level_2"){
				Instantiate(notePlayer2, new Vector3(0,0,0), Quaternion.identity);

			}
			else {
				Instantiate(notePlayer, new Vector3(0,0,0), Quaternion.identity);
			}
		}


		if (other.name.StartsWith("noteC1") || other.name.StartsWith("wallC1")){
			currentNote = 3;
			switchPlayer *= -1;
			if (Application.loadedLevelName == "Level_2"){
				Instantiate(notePlayer2, new Vector3(0,0,0), Quaternion.identity);

			}
			else {
				Instantiate(notePlayer, new Vector3(0,0,0), Quaternion.identity);
			}
		}

		if (other.name.StartsWith("noteC2") || other.name.StartsWith("wallC2")){
			currentNote = 4;
			switchPlayer *= -1;
			if (Application.loadedLevelName == "Level_2"){
				Instantiate(notePlayer2, new Vector3(0,0,0), Quaternion.identity);

			}
			else {
				Instantiate(notePlayer, new Vector3(0,0,0), Quaternion.identity);
			}
		}

		if (other.name.StartsWith("noteD") || other.name.StartsWith("wallD")){
			currentNote = 5;
			switchPlayer *= -1;
			if (Application.loadedLevelName == "Level_2"){
				Instantiate(notePlayer2, new Vector3(0,0,0), Quaternion.identity);

			}
			else {
				Instantiate(notePlayer, new Vector3(0,0,0), Quaternion.identity);
			}
		}

		if (other.name.StartsWith("noteE") || other.name.StartsWith("wallE")){
			currentNote = 6;
			switchPlayer *= -1;
			if (Application.loadedLevelName == "Level_2"){
				Instantiate(notePlayer2, new Vector3(0,0,0), Quaternion.identity);

			}
			else {
				Instantiate(notePlayer, new Vector3(0,0,0), Quaternion.identity);
			}
		}

		if (other.name.StartsWith("noteF") || other.name.StartsWith("wallF")){
			currentNote = 7;
			switchPlayer *= -1;
			if (Application.loadedLevelName == "Level_2"){
				Instantiate(notePlayer2, new Vector3(0,0,0), Quaternion.identity);

			}
			else {
				Instantiate(notePlayer, new Vector3(0,0,0), Quaternion.identity);
			}
		}

		if (other.name.StartsWith("noteG") || other.name.StartsWith("wallG")){
			currentNote = 8;
			switchPlayer *= -1;
			if (Application.loadedLevelName == "Level_2"){
				Instantiate(notePlayer2, new Vector3(0,0,0), Quaternion.identity);

			}
			else {
				Instantiate(notePlayer, new Vector3(0,0,0), Quaternion.identity);
			}
		}


		if (other.name.StartsWith("specialwall1")){
			currentNote = 11;
			switchPlayer *= -1;
			Instantiate(notePlayer2, new Vector3(0,0,0), Quaternion.identity);
		}
		if (other.name.StartsWith("specialwall2")){
			currentNote = 12;
			switchPlayer *= -1;
			Instantiate(notePlayer2, new Vector3(0,0,0), Quaternion.identity);
		}
		if (other.name.StartsWith("specialwall3")){
			currentNote = 13;
			switchPlayer *= -1;
			Instantiate(notePlayer2, new Vector3(0,0,0), Quaternion.identity);
		}
		if (other.name.StartsWith("specialwall4")){
			currentNote = 14;
			switchPlayer *= -1;
			Instantiate(notePlayer2, new Vector3(0,0,0), Quaternion.identity);
		}



	}

	void OnTriggerExit2D(Collider2D other){
		if (other.tag.StartsWith("note")){
			switchPlayer *= -1;
		}
	}


	void Awake () {
		audioPlayer = GetComponent<AudioSource>();
	}

	void Update () {



		if (tunaHolder != playerController.tunaCounter){
			audioPlayer.PlayOneShot(tunaPickup);

			tunaHolder++;
		}


		if (Input.GetKeyUp("s")){
			audioPlayer.Stop();
		}
		isPlaying = audioPlayer.isPlaying;
		audioPlayer.volume = currentVolume;




		if ((Input.GetKeyDown("w")) && (playerController.grounded == true)){
			currentVolume = Random.Range (varLowRange, varHighRange);
			currentPitch = Random.Range ((varLowRange), (varHighRange));
			audioPlayer.PlayOneShot(jump);
		}

		if (((Input.GetKey("d")) || (Input.GetKey("a"))) && (playerController.grounded == true)){
			currentVolume = Random.Range (varLowRange, varHighRange);
			//currentPitch = Random.Range ((varLowRange), (varHighRange));
			currentFootstep = Random.Range (0, 1);
				if (!isPlaying){
					if (currentFootstep == 0){
						audioPlayer.PlayOneShot(footstep1);	
					}
					else {
						audioPlayer.PlayOneShot(footstep2);	
					}
				}
			}
		/*if (Input.GetKey("left shift")){
			currentPitch *= 1.4f;
		}
*/
			}
		

	}

		



