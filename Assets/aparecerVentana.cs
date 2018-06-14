using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aparecerVentana : MonoBehaviour {

	public GameObject ventana;

	// Use this for initialization
	void Start () {
		ventana.SetActive (false);		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void mostrarVentana(){
		ventana.SetActive (true);
	}
	public void ocultarVentana(){
		ventana.SetActive (false);
	}
}
