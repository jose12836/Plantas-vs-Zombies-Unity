using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptRisaInicioNivel : MonoBehaviour {

	bool entro=false;
	public float tiempo = 4;
	float esperarTiempo = 0;

	// Use this for initialization
	public void reproducirSonido () {
		AudioSource audio = GetComponent<AudioSource> ();
		audio.Play ();
		entro = true;
	}

	void Update(){
		if (entro == true) {
			esperarTiempo += Time.deltaTime;
			if (esperarTiempo >= tiempo*3) {
				esperarTiempo = 0;
				SceneManager.LoadScene ("Planta vs Zombies");

			}
		}
	}
}
