using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	
	public List<Plantas> plantasAUsar;
	public GameObject Deck;
	public GameObject prefabCarta;

	public Text TxtSoles;

	int soles=300;
	int plantaAUsar;
	bool click=false;
	bool solesInsufiientes=false;
	public float tiempo = 1;
	float esperarTiempo = 0;

	void Start(){
		actualizarSoles (0);
		solesInsufiientes = false;
		for (int x = 0; x < plantasAUsar.Count; x++) {
			GameObject go = Instantiate (prefabCarta) as GameObject;
			go.transform.SetParent (Deck.transform);
			go.transform.position = Vector3.zero;
			go.transform.localScale = Vector3.one;

			Image img = go.GetComponent<Image> ();
			img.sprite = plantasAUsar [x].cartaAsignada;



			Button bot = go.GetComponent<Button> ();
			bot.onClick.RemoveAllListeners ();
			int i = x;
			bot.onClick.AddListener (() => {click=true; });
			bot.onClick.AddListener (() => {plantaAUsar=i; });

			/*if (plantasAUsar [x].precioSoles > soles) {
				img.GetComponent<Image> ().color = Color.gray;
			}*/
		}
	}

	void Update(){
		if (solesInsufiientes==true) {
			print ("Cambiando Color");
			TxtSoles.color = Color.red;
			esperarTiempo += Time.deltaTime;

			if (esperarTiempo >= tiempo) {
				TxtSoles.color = Color.black;
				solesInsufiientes = false;	
				esperarTiempo = 0;
			}

		}

		if (Input.GetMouseButtonDown (0)) {			
				
			Ray r = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast (r.origin, r.direction);
			if (hit.collider != null) {
				if (plantaAUsar == 6) {
					if (hit.collider.CompareTag ("Planta")) {
						if (click == true) {
							click = false;
							Destroy (hit.collider.gameObject);
						}
					}
					
				}
				if (hit.collider.CompareTag ("Cuadricula")) {
					if (click == true) {
						click = false;
						Transform t = hit.collider.transform;
						crearPlanta (plantaAUsar, t);
					}
				}
				if (hit.collider.CompareTag ("Sol")) {
					actualizarSoles (25);
					Destroy (hit.collider.gameObject);
				}
								
			}
		}
		
	}
	void crearPlanta(int numero,Transform t){
		if (plantasAUsar [numero].precioSoles > soles) {
			solesInsufiientes = true;
			AudioSource audio = GetComponent<AudioSource> ();
			audio.Play ();

		} else {
			if (t.childCount != 0) {
			} else {
				print(plantaAUsar);
				solesInsufiientes = false;
				TxtSoles.color = Color.black;
				GameObject g = Instantiate (plantasAUsar [plantaAUsar].gameObject, t.position, gameObject.transform.rotation) as GameObject;
				g.transform.SetParent (t);

				actualizarSoles (-plantasAUsar [numero].precioSoles);
			}
		}
	}
	public void actualizarSoles(int agregar){
		soles += agregar;
		TxtSoles.text = soles.ToString ();
	}

		
}
