using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

	bool activo;
	public GameObject pause;

	// Use this for initialization
	void Start () {
		
		pause = GameObject.Find("Pause");
		pause.SetActive (false);
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			AudioSource audio = GetComponent<AudioSource> ();
			if (activo == false) {				
				audio.Pause ();
			} else {
				audio.Play ();
			}

			print ("Pause");
			activo = !activo;
			pause.SetActive (activo);
			Time.timeScale = (activo) ? 0 : 1f;
		}

		
	}
	public void Reanudar(){
		AudioSource audio = GetComponent<AudioSource> ();
		audio.Play ();
		activo = !activo;
		pause.SetActive (activo);
		Time.timeScale = 1;	
	}
}
