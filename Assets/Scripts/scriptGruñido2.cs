using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptGruñido2 : MonoBehaviour {

	IEnumerator Start () {
		while (true) {
			yield return new WaitForSeconds (30);
			AudioSource audio = GetComponent<AudioSource> ();
			audio.Play ();
		}

	}
}
