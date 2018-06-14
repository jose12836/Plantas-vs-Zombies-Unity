using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class barraProgreso : MonoBehaviour {
	Slider Barra;

	public float max;
	public float act;
	public Text valorString;

	int num;

	void Start(){
		max = (int)GameObject.Find ("Contador de Enemigos").gameObject.GetComponentInParent<contadorEnemigos> ().enemigos;
	}

	void Awake(){
		Barra = GetComponent<Slider> ();		
	}

	void Update(){
		act = (int)GameObject.Find ("Contador de Enemigos").gameObject.GetComponentInParent<contadorEnemigos> ().enemigos;
		actualizarDatosBarra (max, act);		
	}

	void actualizarDatosBarra(float valorMax, float valorAct){
		float porcentaje;
		porcentaje = valorAct / valorMax;
		Barra.value = porcentaje;
		valorString.text = act + " ZOMBIES";
	}
}
