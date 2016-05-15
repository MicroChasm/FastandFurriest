using UnityEngine;
using System.Collections;

public class collisiontest : MonoBehaviour {
	public bool grounded = false;

	void OnTriggerEnter (Collider other){
		if (other.tag == "ground"){
			grounded = true;
			Debug.Log("collided");
		}
	}
}
