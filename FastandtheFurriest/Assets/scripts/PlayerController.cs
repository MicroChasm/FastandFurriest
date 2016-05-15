using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	float horizontalSpeed = 0;
	public float verticalSpeed = 0;
	public float gravity = 0.1f;
	public Rigidbody2D player;
	public bool grounded = false;
	public bool jumping;
	public int jumpCounter;
	public bool wallClimb = false;
	public int catState = 0;
	public  Animator playerAnimator;
	public int tunaCounter;
	public float jumpSpeed = 2.0f;
	public float runSpeed = 10.0f;
	public float climbSpeed = 1.0f;
	public float fallSpeed = 3;
	public int catLives = 9;
	public Text livesUI;
	public string catLivesString;
	public Vector2 startPosition;
	public Text tunaUI;
	public string tunaString;
	public bool sliding;
	public bool falling;
	public int catColor;
	public GameObject music1;
	public GameObject music2;
	public int currentScene;
	public GameObject musicObject;

	public float moveSpeed;
	//public Grounded GroundCollision;

	void Awake(){
		catColor = PlayerPrefs.GetInt("CatColor");
		if (catColor == 0){
			playerAnimator.SetInteger("CatColor", 0);
		}
		if (catColor == 1){
			playerAnimator.SetInteger("CatColor", 1);
		}
	}

	void Start(){
		currentScene = Application.loadedLevel;
		if (currentScene == 2){
		Instantiate(music1, new Vector3(0,0,0), Quaternion.identity);
		}
		else if (currentScene == 3){

			Instantiate(music2, new Vector3(0,0,0), Quaternion.identity);
		}



		playerAnimator = gameObject.GetComponent<Animator>();
		catState = 0;
		startPosition = player.transform.position;
		grounded = false;
		wallClimb = false;
		jumping = true;
		fallSpeed = 3.0f;
	}

	void OnTriggerStay2D (Collider2D other){
		if (other.name.StartsWith("ground")){
			grounded = true;

		}
		if (other.name.StartsWith("wall")){
			jumping = false;
			grounded = false;
			wallClimb = true;
		}



	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "tuna"){
			tunaCounter++;
			Destroy(other.gameObject);

		}

		if (other.name.StartsWith("Kill") && (sliding == false)){
			musicObject = GameObject.FindGameObjectWithTag("music");

			Destroy(musicObject);

			if (currentScene == 2){

				Instantiate(music1, new Vector3(0,0,0), Quaternion.identity);
			}
			else if (currentScene == 3){

				Instantiate(music2, new Vector3(0,0,0), Quaternion.identity);
			}


			player.transform.position = startPosition;
			if (catLives > 0){
				catLives -= 1;
			}
			else{
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			}

		}
	}

	void OnTriggerExit2D (Collider2D other){
		if (other.name.StartsWith("wall")){
			wallClimb = false;
			catState = 4;
			jumping = true;

		}
		if (other.name.StartsWith("ground")){
			grounded = false;
		}
	}





	// Update is called once per frame
	void Update () {
		catColor = PlayerPrefs.GetInt("CatColor");


		if (catLives == 0){
			Application.LoadLevel(0);
		}

		if (Input.GetKeyDown("l")){
			PlayerPrefs.SetInt("CatColor", 1);
				
		}
		if (Input.GetKeyDown("k")){
				PlayerPrefs.SetInt("CatColor", 0);

			}


				//Debug.Log(catColor);

		tunaString = tunaCounter.ToString();
		tunaUI.text = tunaString;

		if (catLives == 1){
			catLivesString = "1";
			}
		else if (catLives == 2){
			catLivesString = "2";
		}
		else if (catLives == 3){
			catLivesString = "3";
		}		
		else if (catLives == 4){
			catLivesString = "4";
		}		
		else if (catLives == 5){
			catLivesString = "5";
		}		
		else if (catLives == 6){
			catLivesString = "6";
		}		
		else if (catLives == 7){
			catLivesString = "7";
		}		
		else if (catLives == 8){
			catLivesString = "8";
		}		
		else if (catLives == 9){
			catLivesString = "9";
		}




		livesUI.text = catLivesString;
			

		playerAnimator.SetInteger("CatState", catState);
			
		horizontalSpeed = 0.0f;
		verticalSpeed = 0.0f;

		if (wallClimb == true){
			falling = false;
			grounded = false;
			//wallClimb = false;
			jumping = false;
			horizontalSpeed = 0.0f;
			verticalSpeed = climbSpeed;
			//Debug.Log("wallclimb");
			catState = 2;

		}
	if (grounded == true) {
			falling = false;
			//grounded = false;
			wallClimb = false;
			//jumping = false;
			horizontalSpeed = runSpeed;
			//verticalSpeed = .0f;
			catState = 0;
			//Debug.Log("grounded");
			catState = 0;

		}
		if ((grounded == false) && (wallClimb == false) && (jumping == false) ){
			horizontalSpeed = runSpeed;
			verticalSpeed = -fallSpeed;
			jumpSpeed = 3;
			catState = 4;
			falling = true;
			//Debug.Log("falling");
		}


		if (jumping == true){
			falling = false;
			grounded = false;
			wallClimb = false;
			horizontalSpeed = runSpeed;
			verticalSpeed = jumpSpeed;
			jumpSpeed -= .05f;
			jumpCounter++;
			catState = 1;
			//jumpSpeed -= .01f;
		}

		/*
		if (jumping == true){

			Debug.Log("jumping");

		}
		else if (falling == true){

			Debug.Log("falling");

		}
		else if (grounded == true){

			Debug.Log("grounded");

		}
		else if (wallClimb == true){

			Debug.Log("wallclimb");

		}
		else if ((falling == true) && (grounded == true)){

			Debug.Log("falling and grounded");

		}
		else if ((falling == true) && (jumping == true)){

				Debug.Log("falling and jumping");

			}
		else if ((grounded == true) && (jumping == true)){

					Debug.Log("grounded and jumping");

				}
		else if ((wallClimb == true) && (jumping == true)){

			Debug.Log("wallclimb and jumping");

		}
		else if ((wallClimb == true) && (falling == true)){

			Debug.Log("wallclimb and falling");

		}
		else if ((wallClimb == true) && (grounded == true)){

			Debug.Log("wallclimb and grounded");

		}
*/

		if (Input.GetKeyUp("w")){
			jumpCounter = 0;

			jumping = false;
			jumpSpeed = 3.0f;

		}

		if ((grounded == true) && (Input.GetKey("s"))){
			catState = 3;
			sliding = true;
		}
		else {
			sliding = false;

		}




		if (jumpCounter > 50){
			jumpCounter = 0;
			jumping = false;
			jumpSpeed = 1.0f;
		}


		if (Input.GetKeyDown("r")){
			Application.LoadLevel(Application.loadedLevel);
		}


		 if ((Input.GetKey("w")) && (grounded == true)){

			jumping = true;
			catState = 1;
		}

	}

	void LateUpdate(){
		transform.position += new Vector3(horizontalSpeed, verticalSpeed, 0);

	}

			}