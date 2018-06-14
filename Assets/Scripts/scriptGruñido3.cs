using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptGruñido3 : MonoBehaviour {

	IEnumerator Start () {
		while (true) {
			yield return new WaitForSeconds (50);
			AudioSource audio = GetComponent<AudioSource> ();
			audio.Play ();
		}

	}
}
