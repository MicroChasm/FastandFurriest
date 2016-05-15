using UnityEngine;
using System.Collections;

public class MoveLeft : MonoBehaviour {

	public float horizontalSpeed = .2f;

	// Use this for initialization
	void Start () {
		//placement = transform.position;

	}
	
	// Update is called once per frame
	void Update () {
		transform.position -= new Vector3(horizontalSpeed, 0, 0);

	}
}
