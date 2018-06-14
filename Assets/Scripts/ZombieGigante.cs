using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZombieGigante : MonoBehaviour {

	public int vida = 4;
	public float velocidad;
	public LayerMask layerPlanta;	

	public float tiempoAtaque = 1f;

	private SpriteRenderer sr;

	void Start(){
		sr = GetComponent<SpriteRenderer> ();
	}

	void Update(){
		RaycastHit2D hit = Physics2D.Raycast (transform.position, Vector3.left,0.5f,layerPlanta);
		if (hit.collider != null) {
			hit.collider.SendMessage ("GIGANTE");


		} else {
			
			transform.position -= Vector3.right * velocidad * Time.deltaTime;
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.CompareTag ("Guisante")) {
			vida--;
			Destroy (col.gameObject);

			if (vida <= 0) {
				GameObject.Find ("Contador de Enemigos").gameObject.SendMessage ("muerteEnemigo");
				Destroy (gameObject);
			}
		} else {
			if (col.CompareTag ("Sandia")) {
				vida -=2;
				Destroy (col.gameObject);

				if (vida <= 0) {
					GameObject.Find ("Contador de Enemigos").gameObject.SendMessage ("muerteEnemigo");
					Destroy (gameObject);
				}
			} else {
				if (col.CompareTag ("Guisante Hielo")) {
					vida--;
					Destroy (col.gameObject);
					sr.color = Color.blue;
					velocidad = 0.1f;

					if (vida <= 0) {
						GameObject.Find ("Contador de Enemigos").gameObject.SendMessage ("muerteEnemigo");
						Destroy (gameObject);
					}

				}
			}
		}
		if(col.CompareTag("Invasion")){
			SceneManager.LoadScene ("Perdiste");
			Destroy(gameObject);
			print("PERDISTE");
		}
		if(col.CompareTag("Muerte")){
			GameObject.Find ("Contador de Enemigos").gameObject.SendMessage ("muerteEnemigo");
			Destroy(gameObject);
		}
	}
}
