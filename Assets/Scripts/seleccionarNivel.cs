using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class seleccionarNivel : MonoBehaviour {

	public void iniciarNivel1(){
		SceneManager.LoadScene ("Planta vs Zombies");
	}
	public void iniciarNivel2(){
		SceneManager.LoadScene ("Planta vs Zombies 2");
	}
	public void iniciarNivel3(){
		SceneManager.LoadScene ("Planta vs Zombies 3");
	}
	public void iniciarMenu(){
		SceneManager.LoadScene ("Menu");
		Time.timeScale = 1;
	}
	public void salirJuego(){
		Application.Quit();	
	}
	public void niveles(){
		SceneManager.LoadScene ("Seleccion de Niveles");
	}
	public void reiniciarNivel(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
	public void AparecerSeleccion(){
	
	}


}
