using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plantas : MonoBehaviour {

	public Sprite cartaAsignada;
	public int precioSoles;
	public int vida;
	public string nombre;

	public void Morder(){
		vida--;
		if (vida <= 0) {
			Destroy (gameObject);
		}
	}
	public void GIGANTE(){
		print ("GIGANTE");
		Destroy (gameObject);
	}
}
