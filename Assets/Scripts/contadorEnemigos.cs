using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class contadorEnemigos : MonoBehaviour {
	public int enemigos;

	// Update is called once per frame
	void Update () {
		print (enemigos);
		if (enemigos == 0) {
			if (SceneManager.GetActiveScene ().name == "Planta vs Zombies") {
				SceneManager.LoadScene ("Ganaste");		
			} else {
				if (SceneManager.GetActiveScene ().name == "Planta vs Zombies 2") {
					SceneManager.LoadScene ("Ganaste2");		
				} else {
					if (SceneManager.GetActiveScene ().name == "Planta vs Zombies 3") {
						SceneManager.LoadScene ("Ganaste3");		
					}
				}
			}

		}
		
	}
	public void muerteEnemigo(){
		enemigos--;
	}

	public int  getEnemigos(){
		return enemigos;
	}
}
