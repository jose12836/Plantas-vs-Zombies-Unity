using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptGruñido1 : MonoBehaviour {

	IEnumerator Start () {
		while (true) {
			yield return new WaitForSeconds (20);
			AudioSource audio = GetComponent<AudioSource> ();
			audio.Play ();
		}

	}
}
