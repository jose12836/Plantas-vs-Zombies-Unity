using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Podadora : MonoBehaviour {

	bool Zombie=false;
	bool entro=false;

	void Update(){
		
		if (Zombie == true) {
			if (entro == false) {
				AudioSource audio = GetComponent<AudioSource> ();
				audio.Play ();
				entro = true;
			}
			transform.position += Vector3.right * 5f * Time.deltaTime;
		}
	}
	void OnTriggerEnter2D(Collider2D col){
		if (col.CompareTag ("Destruccion")) {
			print("PODADORA");
			Destroy (gameObject);

		}
		if (col.CompareTag ("Zombie")) {
			Zombie = true;		
			print("ZOMBIE");

		}

	}
		
}
